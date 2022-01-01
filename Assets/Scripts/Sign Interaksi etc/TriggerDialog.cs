using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour
{
    public Messagee [] messages;
    public Actorr [] actors;
    Rigidbody2D rb;
    public void StartDialogue()
    {
        rb = GetComponent<Rigidbody2D>();
        FindObjectOfType<Dm2>().OpenDialogue(messages, actors);
        
    }
 
}

[System.Serializable]
public class Messagee 
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorr {
    public string name;
    public Sprite sprite;
}