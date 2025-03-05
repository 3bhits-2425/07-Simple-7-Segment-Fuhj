using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Überprüfe, ob die Taste A gedrückt wird
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Debug-Nachricht, um sicherzustellen, dass die Taste erkannt wird
            Debug.Log("Taste A gedrückt!");

            // Drehe das GameObject um 180 Grad entlang der Y-Achse
            transform.Rotate(90, 0, 0);
        }
    }
}
