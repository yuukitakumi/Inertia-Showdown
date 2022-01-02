using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
public Message [] messages;
public Actor[] actors;
Rigidbody2D rb;
public void StartDialogue()
{
    rb = GetComponent<Rigidbody2D>();
    FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
        
}
 
}

[System.Serializable]
public class Message 
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actor{
    public string name;
    public Sprite sprite;
}