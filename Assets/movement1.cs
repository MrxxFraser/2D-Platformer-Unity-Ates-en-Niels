using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class movement1 : MonoBehaviour
{

    public float kaas = 0.3f;
    public bool cheese = true;
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        for (cheese = true; cheese;)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Translate(kaas, 0, 0);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {

            }
        }
        
    }
}
