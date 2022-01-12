using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenVas: MonoBehaviour
{
    public int counterNeeded;
        public GameManagerVas gameManager;
        public bool isDone;
        public Collider2D collider;
        public Collider2D collidere;
        public GameManagerPrasasti gameManagerPrasasti;
        public Animator anim;
        void Start()
        {
            gameManager = FindObjectOfType<GameManagerVas>();
            gameManagerPrasasti = FindObjectOfType<GameManagerPrasasti>();
        }
    
        // Update is called once per frame
        void Update()
        {
            if (gameManager.counter >= counterNeeded)
            {
                isDone = true;
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
                
            }
            else
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            
            if (gameManagerPrasasti.counter >= counterNeeded)
            {
                isDone = true;
                anim.SetBool("IsOpen", true);
                
            }

        }
}
