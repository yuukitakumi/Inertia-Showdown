using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjekanLibraryPast : MonoBehaviour
{
    
    public GameManager1 gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager1>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")  == true)
            
            gameManager.counter++;
    }
    
}