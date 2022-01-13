using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFx : MonoBehaviour
{
    // Start is called before the first frame update
    
    public AudioSource noteSound;

    void OnTriggerEnter(Collider other)
    {

            noteSound.Play();

    }
}
