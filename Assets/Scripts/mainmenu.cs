using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game");
        Debug.Log("Created by ReCrystX");
    }

    public void GetCredits(){
        Debug.Log("Created by ReCrystX");
    }
}
