using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLemari : MonoBehaviour
{
    public int counterNeeded;
        public GameManager gameManager;
        public bool isDone;
        public Collider2D collider;
    
        void Start()
        {
            gameManager = FindObjectOfType<GameManager>();
    
        }
    
        // Update is called once per frame
        void Update()
        {
            if (gameManager.counter == counterNeeded)
            {
                isDone = true;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
}
