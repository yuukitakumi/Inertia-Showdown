using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTopengPintu : MonoBehaviour
{
    public int counterNeeded;
    public GMTopeng gameManager;
    public bool isDone;
    public Animator animGate;

    public BoxCollider2D boxbox;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GMTopeng>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.counter >= counterNeeded)
        {
            isDone = true;
            animGate.SetBool("IsOpen", true);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
