using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComputerTextField : MonoBehaviour
{
    [Header("Type of TextField")]
    public bool isNameField;
    public bool isAlways;

    private void Start()
    {
        if (isNameField)
        {
            this.GetComponent<TextMeshPro>().text = PlayerPrefs.GetString("username");
        }
    }


    private void Update()
    {
        if (isAlways == true)
        {
            this.GetComponent<TextMeshPro>().text = PlayerPrefs.GetString("username");
        }
    }
}
