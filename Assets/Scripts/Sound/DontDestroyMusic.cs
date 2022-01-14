using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    public Object musicObj1;
    public Object musicObj2;
    public Object musicObj3;
    public Object musicObj4;
    public Object musicObj5;
    public Object musicObj6;


    private void Awake()
    {
        GameObject[] musicObj1 = GameObject.FindGameObjectsWithTag("MusicPlayer");
        GameObject[] musicObj2 = GameObject.FindGameObjectsWithTag("MusicPlayerPast");
        GameObject[] musicObj3 = GameObject.FindGameObjectsWithTag("BaseFuture");
        GameObject[] musicObj4 = GameObject.FindGameObjectsWithTag("BasePast");
        GameObject[] musicObj5 = GameObject.FindGameObjectsWithTag("Tickphase0");
        GameObject[] musicObj6 = GameObject.FindGameObjectsWithTag("Tickphase1");

        if (musicObj1.Length > 1)
        {
            Destroy(this.musicObj1);
        }
        if (musicObj2.Length > 1)
        {
            Destroy(this.musicObj2);
        }
        if (musicObj3.Length > 1)
        {
            Destroy(this.musicObj3);
        }
        if (musicObj4.Length > 1)
        {
            Destroy(this.musicObj4);
        }
        if (musicObj5.Length > 1)
        {
            Destroy(this.musicObj5);
        }
        if (musicObj6.Length > 1)
        {
            Destroy(this.musicObj6);
        }



        DontDestroyOnLoad(this.musicObj1);
        DontDestroyOnLoad(this.musicObj2);
        DontDestroyOnLoad(this.musicObj3);
        DontDestroyOnLoad(this.musicObj4);
        DontDestroyOnLoad(this.musicObj5);
        DontDestroyOnLoad(this.musicObj6);


    }

}