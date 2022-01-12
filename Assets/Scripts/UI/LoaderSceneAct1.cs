using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoaderSceneAct1 : MonoBehaviour 
{
    public Transform Loadbar;
    [SerializeField]
    private float now, speed;

    void Update ()
    {
        if (now < 100)
        {
            now += speed * Time.deltaTime;
            Debug.Log((int)now);
        }
        else
        {
            Application.LoadLevel ("Act1C1D1");
        }
        Loadbar.GetComponent<Image>().fillAmount = now/100;
    }
}