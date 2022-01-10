using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KhususLampu: MonoBehaviour
{
    
    [SerializeField] public GameObject interactUI;


    public bool PlayerInRange;
    public GameObject bohlam;
    public BoxCollider2D box;
    
    public GameManageLampuPapanTulis gameManager;
    public void Start()
    {
        gameManager = FindObjectOfType<GameManageLampuPapanTulis>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            gameManager.counter++;
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