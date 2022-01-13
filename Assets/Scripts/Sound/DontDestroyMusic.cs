using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MusicPlayer");
        GameObject[] musicObj1 = GameObject.FindGameObjectsWithTag("MusicPlayerPast");
        GameObject[] musicObj3 = GameObject.FindGameObjectsWithTag("BaseFuture");
        GameObject[] musicObj4 = GameObject.FindGameObjectsWithTag("BasePast");
        GameObject[] musicObj5 = GameObject.FindGameObjectsWithTag("Tickphase1");
        GameObject[] musicObj6 = GameObject.FindGameObjectsWithTag("Tickphase2");

        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}