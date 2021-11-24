using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueWithNPC : MonoBehaviour
{
    [SerializeField] public GameObject dialogBoxNPC;
    public bool PlayerInRange;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (dialogBoxNPC.activeInHierarchy)
            {
                dialogBoxNPC.SetActive(false);
            }
            else
            {
                dialogBoxNPC.SetActive(true);
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
            dialogBoxNPC.SetActive(false);
        }
    }
}
