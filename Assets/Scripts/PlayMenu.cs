using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    public void SinglePlayer() {
        Debug.Log("Gamemode before the press: " + GameParameters.gameMode);
        GameParameters.gameMode = 0;
        Debug.Log("Gamemode after the press: " + GameParameters.gameMode);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MultiPlayer() {
        Debug.Log("Gamemode before the press: " + GameParameters.gameMode);
        GameParameters.gameMode = 1;
        Debug.Log("Gamemode after the press: " + GameParameters.gameMode);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}