using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] public GameObject dialogBox;
    [SerializeField] public GameObject dialogImage;
    [SerializeField] public Text dialogText;
    [SerializeField] int letterPerSecond;
    public string dialog;
    public bool PlayerInRange;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                dialogImage.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogImage.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
