using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjekanDialogFoto : MonoBehaviour
{
    
    public GameManagerDialogFoto gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManagerDialogFoto>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")  == true)
            
        gameManager.counter++;
    }
    
}