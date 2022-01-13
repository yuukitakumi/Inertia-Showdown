using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HantuIsTriggere : MonoBehaviour
{
    public Animator animHantu;
    public bool PlayerInRange;
    [SerializeField] public GameObject interactUI;

    
    // Start is called before the first frame update
    void Start()
    {
        animHantu = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            Application.LoadLevel("act1c3withdialog");
            interactUI.SetActive(false);
        }

        else
        {
            interactUI.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.CompareTag("Player")  == true)
        animHantu.SetTrigger("IsOpen");
        PlayerInRange = true;
        interactUI.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player") )
        {
            interactUI.SetActive(false);
            PlayerInRange = false;
        }
    }
    
    
}
