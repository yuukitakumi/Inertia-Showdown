using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpRuangRahasia : MonoBehaviour
{
    [SerializeField] public GameObject imageNote;
    [SerializeField] public GameObject panelNote;
    [SerializeField] public GameObject interactUI;
    public GameObject komponen;
   [SerializeField] private AudioSource noteSound;

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
                gameObject.SetActive(false);
                interactUI.SetActive(false);
            }
            else
            {
                noteSound.Play();
                imageNote.SetActive(true);
                panelNote.SetActive(true);
                gameObject.SetActive(true);
                interactUI.SetActive(true);

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
        if (collision.CompareTag("Player") )
        {
            interactUI.SetActive(false);
            PlayerInRange = false;
            imageNote.SetActive(false);
            panelNote.SetActive(false);

        }
    }
}