using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpNotesWithAnimRSebelahPapan : MonoBehaviour
{
    [SerializeField] public GameObject imageNote;
    [SerializeField] public GameObject panelNote;
    [SerializeField] public GameObject lampu;
    [SerializeField] public GameObject interactUI; 
    
    public string note;
    public bool PlayerInRange;
    public GameManageLampuPapanTulis gameManager;
    
    public void Start()
    {
        gameManager = FindObjectOfType<GameManageLampuPapanTulis>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange && gameManager.counter == 1)
        {
            if (imageNote.activeInHierarchy)
            {
                
                imageNote.SetActive(false);
                panelNote.SetActive(false);




            }
            else
            {
                
                imageNote.SetActive(true);
                panelNote.SetActive(true);
                lampu.SetActive(true);
                // dialogText.text = dialog;
                
            }
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
            imageNote.SetActive(false);
            panelNote.SetActive(false);


        }
    }
}