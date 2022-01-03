using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour
{
    public Messagee [] messages;
    public Actorr [] actors;
    public void StartDialogue()
    {
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