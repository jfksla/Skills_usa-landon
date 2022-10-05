using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void Play()
    {
        //open level 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {//Quit Game
        Debug.Log("QUIT");
        Application.Quit();
    }
   
    public void Options()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex = 2);
        // open settings menu
        SceneManager.LoadScene("Settings");
            
 
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("menu");
    }


}

