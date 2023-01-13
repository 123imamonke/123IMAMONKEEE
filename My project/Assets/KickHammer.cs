using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class KickHammer : MonoBehaviour
{ 
public PhotonView PhotonView;
public GameObject Cosmetic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PhotonView.IsMine){

        Cosmetic.SetActive(false);

        }
    }
}
