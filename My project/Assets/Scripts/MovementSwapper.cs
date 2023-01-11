using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;

public class MovementSwapper : MonoBehaviour
{
    public PhotonVRManager manager;

    public Transform FishLeftHand;
    public Transform FishRightHand;
    public Transform FishHead;
    public Transform MonkeyLeftHand;
    public Transform MonkeyRightHand;
    public Transform MonkeyHead;

    public bool ChangeToFish;
    public GameObject fishparent;
    public GameObject monkeparent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter() 
    {
        if (ChangeToFish) 
        {
            monkeparent.SetActive(false);
            fishparent.SetActive(true);
            manager.LeftHand = FishLeftHand;
            manager.RightHand = FishRightHand;
            manager.Head = FishHead;
        
        }
        if(ChangeToFish = false) 
        {
            monkeparent.SetActive(true);
             fishparent.SetActive(true);
            manager.LeftHand = MonkeyLeftHand;
            manager.RightHand = MonkeyRightHand;
            manager.Head = MonkeyHead;
        }
    
    }
}
