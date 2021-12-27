using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueButton : MonoBehaviour
{

    public Button clueb;
    public Text notecaunter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(notecaunter.text == "3"){
            clueb.interactable = true;
         }
        else {
           clueb.interactable = false;
         }
    }
}
