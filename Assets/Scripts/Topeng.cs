using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topeng : MonoBehaviour
{
    [SerializeField] public GameObject interactUI;

    public bool PlayerInRange;
    public bool isDone;
    public GMTopeng gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GMTopeng>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
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
