using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNPC : MonoBehaviour
{
    public Messagere [] messages;
    public Actorer[] actors;

    
    public void StartDialogue()
    {

        FindObjectOfType<DialogManagerNPC>().OpenDialogue(messages, actors);
    }
 
}

[System.Serializable]
public class Messagere 
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actorer
{
    public string name;
    public Sprite sprite;
}