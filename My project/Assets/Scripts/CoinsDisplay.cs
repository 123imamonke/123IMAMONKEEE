using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public coinsScripts coins;
    public TextMeshPro text;
    public string name = "coins";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "You Have " + coins.coins + " " + name;
    }
}