using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DialogManagerNPC : MonoBehaviour
{
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;

    Messagere[] currentMessages;
    Actorer[] currentActors;
    int activeMessage = 0;
    public string scene;
    [SerializeField]
    public static bool isActive = false;

    public void OpenDialogue(Messagere[] messages, Actorer[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("Started conversation! Loaded messages: " + currentMessages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f);
    }

    void DisplayMessage()
    {
        Messagere messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;
        Actorer actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;
        AnimateTextColor();
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            Debug.Log("Conversation Ended!");
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
            isActive = false;
        }
    }

    void AnimateTextColor()
    {
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            NextMessage();
        }
        
       
    }
}
