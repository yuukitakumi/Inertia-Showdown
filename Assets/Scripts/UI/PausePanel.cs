using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour
{
    bool GameIsPaused ;
    public GameObject panelPause;
    public GameObject panelSetting;
    public GameObject panelCredit;
    public GameObject panelQuit;
    

    //public Button BackButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
         
            if(GameIsPaused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame ();
                CloseSetting();
                CloseCredit();
                CloseQuit();

            }
        }
    }

    
    public void ResumeGame()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false ;
    }


    public void PauseGame()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
        
    }
    public void CloseSetting()
    {
       
        panelSetting.SetActive(false);
        panelPause.SetActive(true);
        
    }
    public void CloseCredit()
    {
        
        panelCredit.SetActive(false);
        panelPause.SetActive(true);

    }
    public void CloseQuit()
    {
        
        panelQuit.SetActive(false);
        panelPause.SetActive(true);

    }

}
