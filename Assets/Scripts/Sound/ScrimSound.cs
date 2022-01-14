using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrimSound : MonoBehaviour
{
    public AudioSource screamSound;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        screamSound.Play();
    }
        
    
}
