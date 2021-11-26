using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGate : MonoBehaviour
{
    public string scene;
    public int counterNeeded;
    public GameManager gameManager;
    public bool isDone;
    public Animator animGate;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.counter == counterNeeded)
        {
            isDone = true;
            animGate.SetBool("isOpen", true);
        }
        else
        {
            animGate.SetBool("isOpen", false);
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
