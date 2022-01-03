using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTuyul : MonoBehaviour
{
    public Messager [] messages;
    public Actore[] actors;
    Rigidbody2D rb;
    
    public void StartDialogue()
    {
        rb = GetComponent<Rigidbody2D>();
        FindObjectOfType<DialogManagerTuyul>().OpenDialogue(messages, actors);
    }
 
}

[System.Serializable]
public class Messager 
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actore
{
    public string name;
    public Sprite sprite;
}