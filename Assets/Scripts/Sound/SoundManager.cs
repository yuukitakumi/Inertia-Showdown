using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    Slider volumeSlider;

    public GameObject SoundControl;
    //private float MusicVolume;
    public AudioSource AudiSource1;
    public AudioSource AudiSource2;
    public AudioSource AudiSource3;

    public static SoundManager Instance { get; set; }
    void Start()
    {
        SoundControl = GameObject.FindWithTag("MusicPlayer");
        SoundControl = GameObject.FindWithTag("MusicPlayerPast");
        SoundControl = GameObject.FindWithTag("BaseFuture");
        SoundControl = GameObject.FindWithTag("BasePast");
        SoundControl = GameObject.FindWithTag("Tickphase1");
        SoundControl = GameObject.FindWithTag("Tickphase2");
        AudiSource1 = SoundControl.GetComponent<AudioSource>();
        AudiSource2 = SoundControl.GetComponent<AudioSource>();
        AudiSource3 = SoundControl.GetComponent<AudioSource>();


        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
        }
        else
        {
            Load();
        }
    }

    
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
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
