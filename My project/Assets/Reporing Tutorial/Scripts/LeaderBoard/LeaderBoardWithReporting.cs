using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class LeaderBoardWithReporting : MonoBehaviour
{
    [SerializeField] public string[] usernames;
    [SerializeField] public TMP_Text displaySpot;
    [SerializeField] public string activereportperson;


    private void Update()
    {
        usernames = new string[PhotonNetwork.PlayerList.Length];
        for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
        {
            usernames[i] = PhotonNetwork.PlayerList[i].NickName;
            displaySpot.text = string.Join("\n", usernames);
        }
    }
}
