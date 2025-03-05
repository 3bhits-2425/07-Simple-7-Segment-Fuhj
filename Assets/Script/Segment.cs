using UnityEngine;

public class RotateSegment : MonoBehaviour
{
    public Transform[] segments; // Array von Segmenten

    void Update()
    {
        // Wenn die Zahl 1 gedrückt wird, drehe alle Segmente außer 3 und 6 in X-Richtung
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (var segment in segments)
            {
                if (segment.name != "3" && segment.name != "6")  // Alle außer 3 und 6
                {
                    segment.Rotate(Vector3.right, 90); // Drehe in X-Richtung
                }
            }
        }

        // Wenn die Zahl 2 gedrückt wird, drehe nur die Segmente 3 und 5 in Y-Richtung
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var segment in segments)
            {
                if (segment.name == "3" || segment.name == "5")  // Nur 3 und 5
                {
                    segment.Rotate(Vector3.up, 90); // Drehe in Y-Richtung
                }
            }
        }

        // Wenn die Zahl 3 gedrückt wird, drehe nur die Segmente 3 und 6
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            foreach (var segment in segments)
            {
                if (segment.name == "3" || segment.name == "6")  // Nur 3 und 6
                {
                    segment.Rotate(Vector3.right, 90); // Drehe in X-Richtung
                }
            }
        }

        // Wenn die Zahl 4 gedrückt wird, drehe 1, 5 und 7
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            foreach (var segment in segments)
            {
                if (segment.name == "1" || segment.name == "5" || segment.name == "7")  // 1, 5 und 7
                {
                    segment.Rotate(Vector3.right, 90); // Drehe in X-Richtung
                }
            }
        }

        // Wenn die Zahl 5 gedrückt wird, drehe nur 2 und 6
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            foreach (var segment in segments)
            {
                if (segment.name == "2" || segment.name == "6")  // Nur 2 und 6
                {
                    segment.Rotate(Vector3.up, 90); // Drehe in Y-Richtung
                }
            }
        }

        // Wenn die Zahl 6 gedrückt wird, drehe nur das Segment 3
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            foreach (var segment in segments)
            {
                if (segment.name == "3")  // Nur 3
                {
                    segment.Rotate(Vector3.right, 90); // Drehe in X-Richtung
                }
            }
        }

        // Wenn die Zahl 7 gedrückt wird, drehe alle außer 1, 3 und 6
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            foreach (var segment in segments)
            {
                if (segment.name != "1" && segment.name != "3" && segment.name != "6")  // Alle außer 1, 3 und 6
                {
                    segment.Rotate(Vector3.right, 90); // Drehe in X-Richtung
                }
            }
        }

        // Wenn die Zahl 0 gedrückt wird, drehe nur das Segment 4
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            foreach (var segment in segments)
            {
                if (segment.name == "4")  // Nur 4
                {
                    segment.Rotate(Vector3.right, 90); // Drehe in X-Richtung
                }
            }
        }

        // Wenn die Zahl 9 gedrückt wird, drehe nur das Segment 5
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            foreach (var segment in segments)
            {
                if (segment.name == "5")  // Nur 5
                {
                    segment.Rotate(Vector3.right, 90); // Drehe in X-Richtung
                }
            }
        }
    }
}


