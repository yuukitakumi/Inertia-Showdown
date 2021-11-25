using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOnAnimator : MonoBehaviour
{
    public Animator anim;
    public bool objectInRange;
    void Start()
    {
        anim = GetComponent<Animator>();
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
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pushable"))
        {
            objectInRange = false;
        }
        
    }
}