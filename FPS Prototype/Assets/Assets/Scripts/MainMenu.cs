﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    //Play button action method
    public void PlayGame ()
    {
        //Loading to game scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Hiding and locking cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    //Exit button action method
    public void ExitGame ()
    {
        //Quit application
        Application.Quit();
    }
}
