using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject panelPause;
    //public GameObject panelSetting;

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
        panelPause.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false ;
    }
   

    void PauseGame()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    



    public void menu ()
  {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Testing");
        Debug.Log("Load menu.....");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game...");
    }

}
