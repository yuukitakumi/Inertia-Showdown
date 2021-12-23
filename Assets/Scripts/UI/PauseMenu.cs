using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//1 Turn On PauseMenu
//2 Stop-Time Completely
//3 Pause = true


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false ;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        //to -> Main Menu Scene(belum)
        Debug.Log("Loading Menu.....");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //buildIndex + 1 atau + "MainMenu"
       // Time.timeScale = 1f;
    }

    public void menu ()
  {
      UnityEngine.SceneManagement.SceneManager.LoadScene("mainmenu");
  }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game...");
    }

}
