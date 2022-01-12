using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    public string scene;
  public void playGame ()
  {
      SceneManager.LoadScene(scene);
  }
  public void QuitGame()
      {
          Application.Quit();
      }
}
