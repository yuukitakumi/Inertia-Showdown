using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateRuangSebelah : MonoBehaviour
{
    public int counterNeeded;
        public GameManagerBoxKardus gameManager;
        public bool isDone;
        public Collider2D collider;
    
        void Start()
        {
            gameManager = FindObjectOfType<GameManagerBoxKardus>();
    
        }
    
        // Update is called once per frame
        void Update()
        {
            if (gameManager.counter == counterNeeded)
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
