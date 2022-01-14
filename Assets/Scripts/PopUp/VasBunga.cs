using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VasBunga : MonoBehaviour
{
    [SerializeField] public GameObject imageNote;
    [SerializeField] public GameObject panelNote;
    [SerializeField] public GameObject interactUI; 
    
    public Animator anim;
    public GameManagerVas gameManager;
    public GameManagerPrasasti gameManagerPrasasti;
    public BoxCollider2D col;
    public string note;
    public bool PlayerInRange;

   
    public AudioSource vaseSound;

    // Update is called once per frame

    void Start()
    {
        gameManager = FindObjectOfType<GameManagerVas>();
        gameManagerPrasasti = FindObjectOfType<GameManagerPrasasti>();
    }
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
                vaseSound.Play();
                imageNote.SetActive(true);
                panelNote.SetActive(true);
                gameManager.counter++;
                gameManagerPrasasti.counter++;
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
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}