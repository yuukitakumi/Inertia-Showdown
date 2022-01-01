using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerphoto : MonoBehaviour
{
public Messageeee [] messages;
public Actorrrr[] actors;
Rigidbody2D rb;
public void StartDialogue()
{
    rb = GetComponent<Rigidbody2D>();
    FindObjectOfType<DialogForPhotos>().OpenDialogue(messages, actors);
        
}
 
}

[System.Serializable]
public class Messageeee
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorrrr{
    public string name;
    public Sprite sprite;
}

