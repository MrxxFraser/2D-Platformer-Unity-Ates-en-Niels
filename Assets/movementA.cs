using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class movementA : MonoBehaviour
{

    float kaas = 1f;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
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
