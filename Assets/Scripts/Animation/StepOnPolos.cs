using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOnPolos : MonoBehaviour
{
    public bool objectInRange;
    public string tap;
    public GameManagerBoxKardus gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManagerBoxKardus>();

    }
    // Update is called once per frame
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