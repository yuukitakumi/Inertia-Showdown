using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injekan : MonoBehaviour
{
    
    public GameManager3 gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager3>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")  == true)
            
        gameManager.counter++;
    }
    
}