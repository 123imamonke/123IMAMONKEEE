using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.XR;

//Made By JokerJosh#6230

public class Reporting : MonoBehaviour
{
    public TextMeshPro playerUsername;

    public LeaderBoard script;

    public bool reporting;
    public bool isKey1;
    public bool isKey2;
    public bool isKey3;
    public bool isKey4;
    public bool isKey5;
    public bool isKey6;
    public bool isKey7;
    public bool isKey8;
    public bool isKey9;
    public bool isKey10;
    public bool isKey11;
    public bool isKey12;
    public bool isKey13;
    public bool isKey14;
    public bool isKey15;
    public bool isKey16;
    public bool isKey17;
    public bool isKey18;
    public bool isKey19;
    public bool isKey20;


    public bool HateSpeach;
    public bool Toxic;
    public bool Cheating;

    string webhook_link = "https://discord.com/api/webhooks/1063007686226104330/9vBou-Nxsr3c33EtEmQ1Gw3bEB4HfHqwGXZ6mkgLjs1cHnWTFhfZ7MHXHrId7qc7Isuj";

    private void OnTriggerEnter(Collider other)
    {
        base.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        if (reporting)
        {
            if (isKey1)
            {
                script.activereportperson = script.usernames[0];
            }
            if (isKey2)
            {
                script.activereportperson = script.usernames[1];
            }
            if (isKey3)
            {
                script.activereportperson = script.usernames[2];
            }
            if (isKey4)
            {
                script.activereportperson = script.usernames[3];
            }
            if (isKey5)
            {
                script.activereportperson = script.usernames[4];
            }
            if (isKey6)
            {
                script.activereportperson = script.usernames[5];
            }
            if (isKey7)
            {
                script.activereportperson = script.usernames[6];
            }
            if (isKey8)
            {
                script.activereportperson = script.usernames[7];
            }
            if (isKey9)
            {
                script.activereportperson = script.usernames[8];
            }
            if (isKey10)
            {
                script.activereportperson = script.usernames[9];
            }
            if (isKey11)
            {
                script.activereportperson = script.usernames[10];
            }
            if (isKey12)
            {
                script.activereportperson = script.usernames[11];
            }
            if (isKey13)
            {
                script.activereportperson = script.usernames[12];
            }
            if (isKey14)
            {
                script.activereportperson = script.usernames[13];
            }
            if (isKey15)
            {
                script.activereportperson = script.usernames[14];
            }
            if (isKey16)
            {
                script.activereportperson = script.usernames[15];
            }
            if (isKey17)
            {
                script.activereportperson = script.usernames[16];
            }
            if (isKey18)
            {
                script.activereportperson = script.usernames[17];
            }
            if (isKey19)
            {
                script.activereportperson = script.usernames[18];
            }
            if (isKey20)
            {
                script.activereportperson = script.usernames[19];
            }
            if (Toxic)
            {
                if (script.activereportperson == "")
                {

                }else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Toxic" + "     ", (success) =>
                    {
                        if (success)
                            Debug.Log("Sent = " + "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Toxic" + "     ");
                    }));
                }
            }
            if (HateSpeach)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "HateSpeach" + "     ", (success) =>
                    {
                        if (success)
                            Debug.Log("Sent = " + "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "HateSpeach" + "     ");
                    }));
                }
            }
            if (Cheating)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Cheating" + "     ", (success) =>
                    {
                        if (success)
                            Debug.Log("Sent = " + "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Cheating" + "     ");
                    }));
                }
            }
        }
    }

    IEnumerator SendWebhook(string link, string message, System.Action<bool> action)
    {
        WWWForm form = new WWWForm();
        form.AddField("content", message);
        using (UnityWebRequest www = UnityWebRequest.Post(link, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                action(false);
            }
            else
                action(true);
        }
    }
}
