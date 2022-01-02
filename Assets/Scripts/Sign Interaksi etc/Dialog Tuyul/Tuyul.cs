﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyul : MonoBehaviour
{
    public TriggerTuyul trigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")  == true)
            trigger.StartDialogue();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == false)
            trigger.StartDialogue();
    }
}
