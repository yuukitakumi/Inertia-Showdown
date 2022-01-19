using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CClue: MonoBehaviour
{
    bool GameIsPaused ;

    public GameObject panelTutor;
    
    

    //public Button BackButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
         
            if(GameIsPaused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame ();

            }
        }
    }

    
    public void ResumeGame()
    {
        panelTutor.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false ;
    }


    public void PauseGame()
    {
        panelTutor.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
        
    }

}