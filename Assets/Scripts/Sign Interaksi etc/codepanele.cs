using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codepanele : MonoBehaviour
{
    [SerializeField] public GameObject interactUI;
    [SerializeField]
	GameObject codePanel, closedSafe, openedSafe, diarySafe;
    
    public string note;
    public static bool isSafeOpened = false;
    public bool PlayerInRange;

    // Update is called once per frame
    void start()
    {
        // codePanel.SetActive (false);
		// closedSafe.SetActive (true);
		// openedSafe.SetActive (false);
        // diarySafe.SetActive (false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (isSafeOpened) 
        {
			codePanel.SetActive (false);
			closedSafe.SetActive (true);
			openedSafe.SetActive (false);
            diarySafe.SetActive (false);
		}       
            else
            {
                
            codePanel.SetActive (true);
		    closedSafe.SetActive (false);
		    openedSafe.SetActive (true);
            diarySafe.SetActive (true);

            // dialogText.text = dialog;
                
            }
        }
       
    void OnDisable()
    {
        codePanel.SetActive (true);
    }

    void OnEnable()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (isSafeOpened) 
        {
			codePanel.SetActive (false);
			closedSafe.SetActive (true);
			openedSafe.SetActive (false);
            diarySafe.SetActive (false);
		}       
            else
            {
                
            codePanel.SetActive (true);
		    closedSafe.SetActive (false);
		    openedSafe.SetActive (true);
            diarySafe.SetActive (true);

            // dialogText.text = dialog;
                
            }
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

        // if (collision.gameObject.name.Equals ("Safe") && !isSafeOpened) 
			
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(false);
            PlayerInRange = false;
            codePanel.SetActive (false);
        }
        
        else
        {
            interactUI.SetActive(true);
            PlayerInRange = true;
        }
        // if (collision.gameObject.name.Equals ("Safe")) 
			
    }
}

