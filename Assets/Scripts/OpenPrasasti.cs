using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPrasasti: MonoBehaviour
{
        public int counterNeeded;
        public bool isDone;
        public Collider2D collider;

        public GameManagerPrasasti gameManagerPrasasti;
        public Animator anim;
        void Start()
        {
            gameManagerPrasasti = FindObjectOfType<GameManagerPrasasti>();
        }
    
        // Update is called once per frame
        void Update()
        {
            if (gameManagerPrasasti.counter >= counterNeeded)
            {
                isDone = true;
                anim.SetBool("IsOpen", true);
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }

        }
}
