using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyul : MonoBehaviour
{
    public TriggerTuyul trigger;
    public GameManager1 gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager1>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")  == true)
            trigger.StartDialogue();
        gameManager.counter++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == false)
            trigger.StartDialogue();
    }
}
