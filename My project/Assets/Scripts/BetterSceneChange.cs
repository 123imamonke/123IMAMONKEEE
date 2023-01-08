using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetterSceneChange : MonoBehaviour
{
public string NewLevel = "";  
       


public void OnTriggerEnter(Collider other){
        if(other.tag == "HandTag"){



        
        SceneManager.LoadScene(NewLevel);
        }
}
      }