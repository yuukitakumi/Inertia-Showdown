using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepMain1 : MonoBehaviour
{
    public Animator anim;
    public bool objectInRange;
    public string tap;
    public GameManagerMain gameManager;
    void Start()
    {      
        anim = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManagerMain>();

    }
    // Update is called once per frame
    void Update()
    {
        if (objectInRange)
        {
            anim.SetBool("stepIN", true);
        }
        else
        {
            anim.SetBool("stepIN", false);
        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Pushable"))
        {              
            objectInRange = true;
            if (collision.GetComponent<StatueController>().tap == tap)
            {
                gameManager.counter++;
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pushable"))
        {
            objectInRange = false;
            if (collision.GetComponent<StatueController>().tap == tap)
            {
                gameManager.counter--;
            }
        }
        
    }
}
