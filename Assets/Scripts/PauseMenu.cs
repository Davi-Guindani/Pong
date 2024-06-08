using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key pressed");
            if (isPaused)
            {
                Debug.Log("Game is paused, resuming...");
                ResumeGame();
            }
            else
            {
                Debug.Log("Game is running, pausing...");
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        Debug.Log("Resuming game");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame()
    {
        Debug.Log("Pausing game");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void GoToMainMenu() 
    {
        Debug.Log("Going to main menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
