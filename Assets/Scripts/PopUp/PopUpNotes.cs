using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpNotes : MonoBehaviour
{
    [SerializeField]
    public GameObject imageNote;
    [SerializeField]
    public GameObject panelNote;

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
            imageNote.SetActive(false);
            panelNote.SetActive(false);
        }
    }
}