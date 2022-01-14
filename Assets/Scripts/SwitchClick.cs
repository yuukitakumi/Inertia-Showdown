using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchClick : MonoBehaviour
{
    [SerializeField] public GameObject interactUI;

    public bool PlayerInRange;
    public bool isDone;
    public GameManager gameManager;

    public AudioSource switchSound;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            switchSound.Play();
            isDone = true;
            gameManager.counter++;
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
        }
    }
}
