using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{

    public float distance = 1f;
    public LayerMask boxMax;
    public GameObject statue;
    public PlayerMovement playerMovement;
    public RaycastHit2D hit;
    public bool isGrab;
    public GameObject Xmove;
    public bool isMoving;
    [SerializeField] private AudioSource SuaraDorong1;
    [SerializeField]
    private AudioSource SuaraDorong2;
    [SerializeField]
    private AudioSource SuaraDorong3;
    [SerializeField]
    private AudioSource SuaraDorong4;
    [SerializeField]
    private AudioSource SuaraDorong5;

    // Start is called before the first frame update
    void Start()
    {

        playerMovement = FindObjectOfType<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.movement.x != 0 || playerMovement.movement.y != 0)
        {
            isMoving = true;
        }
        else if (playerMovement.movement.x == 0 && playerMovement.movement.y == 0)
        {
            isMoving = false;

        }

        Physics2D.queriesStartInColliders = false;
        if (playerMovement.movement.y != 0)
        {
            hit = Physics2D.Raycast(transform.position, Vector2.up * playerMovement.movement.y, distance, boxMax);

        }
        else if (playerMovement.movement.x != 0 && playerMovement.movement.y == 0)
        {
            hit = Physics2D.Raycast(transform.position, Vector2.right * playerMovement.movement.x, distance, boxMax);

        }
        if (hit.collider != null && hit.collider.gameObject.tag == "Pushable")
        {
            Xmove.SetActive(true);
        }
        else
        {
            Xmove.SetActive(false);
        }


        if (hit.collider != null && hit.collider.gameObject.tag == "Pushable" && Input.GetKeyDown(KeyCode.X))
        {

            isGrab = !isGrab;
            if (isGrab && Input.GetKeyDown(KeyCode.X))
            {

                SuaraDorong1.Play();
                SuaraDorong2.Play();
                SuaraDorong3.Play();
                SuaraDorong4.Play();
                SuaraDorong5.Play();

                Xmove.SetActive(false);
                statue = hit.collider.gameObject;
                statue.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                statue.GetComponent<FixedJoint2D>().enabled = true;

                statue.GetComponent<FixedJoint2D>().connectedBody = GetComponent<Rigidbody2D>();

            }
            else
            {
                isMoving = false;

                SuaraDorong1.Stop();
                SuaraDorong2.Stop();
                SuaraDorong3.Stop();
                SuaraDorong4.Stop();
                SuaraDorong5.Stop();

                Xmove.SetActive(true);
                statue.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                statue.GetComponent<FixedJoint2D>().enabled = false;
                statue.GetComponent<FixedJoint2D>().connectedBody = null;
                statue.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                statue = null;
            }
        }


        if (!isGrab && isMoving)
        {
            SuaraDorong1.Play();
            SuaraDorong2.Play();
            SuaraDorong3.Play();
            SuaraDorong4.Play();
            SuaraDorong5.Play();


        }
        else if (!isMoving)
        {
            SuaraDorong1.Stop();
            SuaraDorong2.Stop();
            SuaraDorong3.Stop();
            SuaraDorong4.Stop();
            SuaraDorong5.Stop();

        }
        else if (!isGrab)
        {
            SuaraDorong1.Stop();
            SuaraDorong2.Stop();
            SuaraDorong3.Stop();
            SuaraDorong4.Stop();
            SuaraDorong5.Stop();

        }
    }
}
