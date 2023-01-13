using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        {
            Application.Quit();
        }
    }
}