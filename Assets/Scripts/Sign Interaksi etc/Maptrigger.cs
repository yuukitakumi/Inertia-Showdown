using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maptrigger : MonoBehaviour
{
    public DialogTrigger trigger;
    public GameManager1 gameManager;
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
