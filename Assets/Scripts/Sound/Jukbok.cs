using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jukbok : MonoBehaviour
{
    public AudioSource jukSound;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            jukSound.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        jukSound.Pause();
    }
}