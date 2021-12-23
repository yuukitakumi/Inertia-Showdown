using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
  public void playGame ()
  {
      UnityEngine.SceneManagement.SceneManager.LoadScene("Library (Future)");
  }
  public void QuitGame()
      {
          Application.Quit();
      }
}
