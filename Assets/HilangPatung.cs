using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HilangPatung: MonoBehaviour
{
    
    [SerializeField] public GameObject interactUI;
    
    public bool PlayerInRange;
    public GameObject komponen;
    public BoxCollider2D box;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.SetActive(false);
        }
       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(true);
            PlayerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(false);
            PlayerInRange = false;
        }
    }
}