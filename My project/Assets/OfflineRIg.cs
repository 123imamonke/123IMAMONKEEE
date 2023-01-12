using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.VR;

public class OfflineRIg : MonoBehaviour
{

    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject Head;
    public PhotonVRManager Manager;

    void Update() 
    {
        if (PhotonNetwork.InRoom == false) 
        {
        LeftHand.SetActive(true);
            RightHand.SetActive(true);
            Head.SetActive(true);
            LeftHand.transform.position = Manager.LeftHand.position;
            RightHand.transform.position = Manager.RightHand.position;
            Head.transform.position = Manager.Head.position;
        
        }
    if(PhotonNetwork.InRoom) 
        {
        LeftHand.SetActive(false);
            RightHand.SetActive(false);
            Head.SetActive(false);
        
        }
    
    }
}
