using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loadsceene : MonoBehaviour 
{
    public Transform Loadbar;
    [SerializeField]
    private float now, speed;
    public string scene;

    void Update ()
    {
        if (now < 100)
        {
            now += speed * Time.deltaTime;
            Debug.Log((int)now);
            
            
        }
        else
        {
            // Application.LoadLevel ("Ruang Bedrom (Past)");
            SceneManager.LoadScene(scene);
        }
        Loadbar.GetComponent<Image>().fillAmount = now/100;
    }
}