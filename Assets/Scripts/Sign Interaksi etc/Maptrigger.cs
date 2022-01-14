using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maptrigger : MonoBehaviour
{
    public DialogTrigger trigger;
    public AudioSource noteSound;

    public GameManager2 gameManager;
    public void Start()
    {
        gameManager = FindObjectOfType<GameManager2>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")  == true)
            trigger.StartDialogue();
        
        gameManager.counter++;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == false)
            trigger.StartDialogue();

    }
}
