using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class movement1 : MonoBehaviour
{

    public float kaas = 0.02f;
    public bool cheese = true;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(-kaas, 0, 0 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {

            }
    }
}
