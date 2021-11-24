using System.Collections;
using UnityEngine;
using UnityEngine.UI;
namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;
        [Header ("Text Option")]
        [SerializeField] private string input;
        [SerializeField] private Color textColor;
        [SerializeField] private Font textFont;

        [Header("Time Para")]
        [SerializeField] private float delay;
        [SerializeField] private float delayBetweenLines;

        [Header("Image")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image imageholder;
        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";           
            imageholder.sprite = characterSprite;
            
        }

        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay, delayBetweenLines));
        }
    }
}
