using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EndedExit : MonoBehaviour
{
    public VideoPlayer VideoPlayer;

    void Start()
    {
        VideoPlayer.loopPointReached += LoadScene;
    }
    void LoadScene(VideoPlayer vp)
    {
        Application.Quit();
        Debug.Log("KELUAR BANGSAT");
    }
}

