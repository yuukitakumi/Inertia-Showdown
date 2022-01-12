using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPintuMeeting : MonoBehaviour
{
        public int counterNeeded;
        public GameManager3 gameManager;
        public bool isDone;
        public Collider2D collider;
    
        void Start()
        {
            gameManager = FindObjectOfType<GameManager3>();
            collider = FindObjectOfType<Collider2D>();

        }
    
        // Update is called once per frame
        void Update()
        {
            if (gameManager.counter >= counterNeeded)
            {
                isDone = true;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                gameObject.SetActive(false);
                collider.isTrigger = false;
            }
            else
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
}
