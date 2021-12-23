using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSpike : MonoBehaviour
{
    public int counterNeeded;
    public GameManager gameManager;
    public bool isDone;
    public Animator animGate;
    public Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.counter == counterNeeded)
        {
            isDone = true;
            animGate.SetBool("isOpen", true);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {           
            animGate.SetBool("isOpen", false);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }    
    }
}
