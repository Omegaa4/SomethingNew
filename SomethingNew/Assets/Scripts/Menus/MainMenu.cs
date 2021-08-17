using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

 //PlayGame() function has been moved to LevelLoader script for ease of coding

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void SetFullScreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

}
