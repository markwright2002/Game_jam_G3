using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour
{
    private float x, y;
    // Start is called before the first frame update
    void Start()
    {
        x = 0; 
    }

    // Update is called once per frame
    void Update()
    {
       if (x == 0)
        {
            y = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                x = 1;
                
            }

        } else if (x >= 1)
        {

            transform.Rotate(0.0f, 0.0f, x, Space.Self);
            y++;
            if (y >= 120)
            {
                x = -1;
                y = 0;
            }

        }
        else if (x <= -1)
        {
            transform.Rotate(0.0f, 0.0f, x, Space.Self);
            y++;
            if (y >= 120)
            {
                x = 0;
                y = 0;
            }

        }
    }
}
