using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject quitConfirmationScreens;

    public void BackToPauseScreen()
    {
        quitConfirmationScreens.SetActive(false);
        pauseScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}