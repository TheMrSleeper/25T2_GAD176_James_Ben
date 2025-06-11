using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Rotate turret with Q and E
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            // Rotate turret left
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            // Rotate turret right
            transform.Rotate(0, 1, 0);
        }
    }
}
