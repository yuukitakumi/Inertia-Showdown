using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnimation : MonoBehaviour
{
    public int counterNeeded;
    public GameManager gameManager;

    public Animator animHantu;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.counter == counterNeeded)
        {
            animHantu.SetBool("IsOpen", true);
        }
    }


}
