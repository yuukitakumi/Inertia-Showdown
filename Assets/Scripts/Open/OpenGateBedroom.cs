using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGateBedroom : MonoBehaviour
{
    public string scene;
    public int counterNeeded;
    public GMBP gameManager;
    public bool isDone;
    public Animator animGate;
   // public AudioSource gateSound;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GMBP>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.counter == counterNeeded)
        {
            //gateSound.Play();
            isDone = true;
            animGate.SetBool("isOpen", true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDone)
        {
            if (collision.CompareTag("Player"))
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
}
