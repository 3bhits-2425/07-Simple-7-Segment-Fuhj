using UnityEngine;
using System.Collections;

public class RotateSegment : MonoBehaviour
{
    public Transform[] segments; // Array von Segmenten
    public float rotationSpeed = 5f; // Geschwindigkeit der Rotation
    private Quaternion[] initialRotations; // Speichert die Startrotationen der Segmente

    void Start()
    {
        // Speichert die Anfangsrotationen der Segmente
        initialRotations = new Quaternion[segments.Length];
        for (int i = 0; i < segments.Length; i++)
        {
            initialRotations[i] = segments[i].rotation;
        }
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            ResetSegments(); // Setzt alle Segmente zurück, bevor eine neue Drehung beginnt

            if (Input.GetKeyDown(KeyCode.Alpha1)) RotateSegmentsSmoothly(new string[] { "1", "3", "4", "6", "7", "8" });
            if (Input.GetKeyDown(KeyCode.Alpha2)) RotateSegmentsSmoothly(new string[] { "2", "6" }, Vector3.right);
            if (Input.GetKeyDown(KeyCode.Alpha3)) RotateSegmentsSmoothly(new string[] { "2", "5" });
            if (Input.GetKeyDown(KeyCode.Alpha4)) RotateSegmentsSmoothly(new string[] { "1", "5", "7" });
            if (Input.GetKeyDown(KeyCode.Alpha5)) RotateSegmentsSmoothly(new string[] { "3", "5" }, Vector3.right);
            if (Input.GetKeyDown(KeyCode.Alpha6)) RotateSegmentsSmoothly(new string[] { "3" });
            if (Input.GetKeyDown(KeyCode.Alpha7)) RotateSegmentsSmoothly(new string[] { "2", "4", "5", "7", "8" });
            if (Input.GetKeyDown(KeyCode.Alpha0)) RotateSegmentsSmoothly(new string[] { "4" });
            if (Input.GetKeyDown(KeyCode.Alpha9)) RotateSegmentsSmoothly(new string[] { "5" });
        }
    }

    void ResetSegments()
    {
        // Setzt alle Segmente auf ihre ursprüngliche Rotation zurück
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].rotation = initialRotations[i];
        }
    }

    void RotateSegmentsSmoothly(string[] segmentNames, Vector3 axis = default)
    {
        if (axis == default) axis = Vector3.right; // Standardmäßig in X-Richtung drehen

        foreach (var segment in segments)
        {
            if (System.Array.Exists(segmentNames, name => segment.name == name))
            {
                StartCoroutine(RotateOverTime(segment, axis, 90f));
            }
        }
    }

    IEnumerator RotateOverTime(Transform segment, Vector3 axis, float angle)
    {
        Quaternion startRotation = segment.rotation;
        Quaternion endRotation = segment.rotation * Quaternion.AngleAxis(angle, axis);
        float time = 0;

        while (time < 1)
        {
            time += Time.deltaTime * rotationSpeed;
            segment.rotation = Quaternion.Slerp(startRotation, endRotation, time);
            yield return null;
        }
    }
}
