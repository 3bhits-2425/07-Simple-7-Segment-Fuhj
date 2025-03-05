using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChanger : MonoBehaviour
{
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = Color.green;
        }
    }
}

