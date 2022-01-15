using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBear : MonoBehaviour
{
    public GameObject detector;
    Vector3 pos_awal;
    public GameManager gameManager;
    public bool on_pos = false, on_tempel = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        pos_awal = transform.position;
        // scale_awal = transform.localScale;
    }
    void OnMouseDrag()
    {
        Vector3 pos_mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        transform.position = new Vector3(pos_mouse.x, pos_mouse.y, -1);
        // transform.localScale = new Vector2(1f, 1f);
    }

    void OnMouseUp()
    {
        if (on_pos)
        {
            transform.position = detector.transform.position;
            //transform.localScale = new Vector2(1f, 1f);
            on_tempel = true;
            gameManager.counter++;
        }
        else
        {
            transform.position = pos_awal;
            // transform.localScale = scale_awal;
            on_tempel = false;
            gameManager.counter--;
        }
    }

    void OnTriggerStay2D(Collider2D objek)
    {
        if (objek.gameObject == detector)
        {
            on_pos = true;
        }
    }

    void OnTriggerExit2D(Collider2D objek)
    {
        if (objek.gameObject == detector)
        {
            on_pos = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
