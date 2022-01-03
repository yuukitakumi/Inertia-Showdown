using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public Slider volumeSlider;
    public static Music Instance { get; set; }

    private void awake()
    {
        DontDestroyOnLoad(this);
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    
    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

}
