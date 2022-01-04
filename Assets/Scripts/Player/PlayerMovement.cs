using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    
    [SerializeField]
	GameObject codePanel, closedSafe, openedSafe, diarySafe, dialogLeader;

	public static bool isSafeOpened = false;
	
	

    // Update is called once per frame

    // Update is called once per frame

    void start()
    {
        rb = GetComponent<Rigidbody2D> ();
		codePanel.SetActive (false);
		closedSafe.SetActive (true);
		openedSafe.SetActive (false);
        diarySafe.SetActive (false);
        dialogLeader.SetActive (true);
    }

    void Update()
    {
	    if (DialogueManager.isActive == true)
		    GetComponent<Rigidbody2D>().position = Vector2.positiveInfinity;
	    
	    if (Dm2.isActive == true)
		    return;
	    
	    if (DialogForPhotos.isActive == true)
		    GetComponent<Rigidbody2D>().position = Vector2.positiveInfinity;

	    if (DialogManagerTuyul.isActive == true)
	    {
		    GetComponent<Rigidbody2D>().position = Vector2.positiveInfinity;
	    }
	    
	    if (DialogManagerNPC.isActive == true)
			return;
	    
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude); 

        if (isSafeOpened) 
        {
			codePanel.SetActive (false);
			closedSafe.SetActive (false);
			openedSafe.SetActive (true);
            diarySafe.SetActive (true);
            dialogLeader.SetActive (false);
		} 

        else
        {
            diarySafe.SetActive (false);
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Safe") && !isSafeOpened) 
			codePanel.SetActive (true);

		
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Safe")) 
			codePanel.SetActive (false);
		
	}
	
}
