﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateRuangRahasia : MonoBehaviour
{
    public int counterNeeded;
        public GameManagerPrasasti gameManager;
        public bool isDone;
        public Collider2D collider;
    
        void Start()
        {
            gameManager = FindObjectOfType<GameManagerPrasasti>();
    
        }
    
        // Update is called once per frame
        void Update()
        {
            if (gameManager.counter >= counterNeeded)
            {
                isDone = true;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
}
