using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindForce : MonoBehaviour
{
    [Header("GAY KIDSS.")]
    [Header("I LOVE DRUGS")]

    [Header("Gorilla Rig Stuff")]
    public Rigidbody GorillaPlayer;

    [Header("Force")]

    public int XForce;
    public int YForce;
    public int ZForce;

    //Private Stuff

    bool Triggered;
 
    
  void OnTriggerEnter() 
    {
        Triggered = true;
    
    }

    void OnTriggerExit()
    {
        Triggered = false;

    }

    void Update() 
    {
        if (Triggered)
        {
            GorillaPlayer.AddForce(new Vector3(XForce, YForce, ZForce), ForceMode.Impulse);
        }
    }
    }

