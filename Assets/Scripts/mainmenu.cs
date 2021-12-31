using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
  public void playGame ()
  {
      UnityEngine.SceneManagement.SceneManager.LoadScene("Act1");
  }
  public void QuitGame()
      {
          Application.Quit();
      }
}
