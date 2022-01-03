using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory_main : MonoBehaviour
{
    public TextMeshProUGUI noteCounter;
    public TextMeshProUGUI noteCounterr;
    public TextMeshProUGUI keyCounter;
    public GameObject pane;
    public GameObject panel;

    private int notes;
    private int keys = 0;
    

    void Update () {
        if(CollectManager.instance.jumnote == "1"){
                    panel.SetActive(true);
                    pane.SetActive(false);
                } else if(CollectManager.instance.jumnote == "0") {
                    notes = 0;
                    panel.SetActive(false);
                    pane.SetActive(true);
                }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("collectible")){
            Collect(other.GetComponent<Collectible>());
        }
    }

    private void Collect(Collectible collectible){
        if(collectible.Collect()){
            if(collectible is NoteCollect){
                if(CollectManager.instance.jumnote == "1"){

                    notes = 1;
                } else if(CollectManager.instance.jumnote == "0") {
                    notes = 0;
                }
               notes++;
            }
            else if (collectible is KeyCollect)
            {
                keys++;
            }
            UpdateGUI();
        }
    }

    private void UpdateGUI(){
        noteCounter.text = notes.ToString();
        noteCounterr.text = notes.ToString();
        CollectManager.instance.jumnote = notes.ToString();

        keyCounter.text = keys.ToString();
        CollectManager.instance.jumkey = keys.ToString();
    }

}
