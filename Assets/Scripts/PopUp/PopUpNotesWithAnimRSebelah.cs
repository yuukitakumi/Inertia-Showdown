using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpNotesWithAnimRSebelah : MonoBehaviour
{
    [SerializeField] public GameObject imageNote;
    [SerializeField] public GameObject panelNote;
    [SerializeField] public GameObject interactUI; 
    
    public Animator anim;

    public string note;
    public bool PlayerInRange;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
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
                
                // dialogText.text = dialog;
                
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            anim.SetBool("IsOpen", true);
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