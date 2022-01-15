using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKaca : MonoBehaviour
{
    public int counterNeeded;
    public GameManagerMain gameManager;
    public bool isDone;
    public Animator animGate;
    public Collider2D collider;

    [SerializeField]private AudioSource OpenGlass;
    //public AudioSource CloseGlass;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManagerMain>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.counter >= counterNeeded)
        {
            // CloseGlass.Play();
            // OpenGlass.Stop();
            isDone = true;
            animGate.SetBool("isOpen", true);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            // this.OpenGlass.playOnAwake = false;
            OpenGlass.Play();
            animGate.SetBool("isOpen", false);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
