using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public TextMeshProUGUI noteCounter;
    public TextMeshProUGUI keyCounter;

    private int notes = 0;
    private int keys = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("collectible")){
            Collect(other.GetComponent<Collectible>());
        }
    }

    private void Collect(Collectible collectible){
        if(collectible.Collect()){
            if(collectible is NoteCollect){
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
        CollectManager.instance.jumnote = notes.ToString();

        keyCounter.text = keys.ToString();
        CollectManager.instance.jumkey = keys.ToString();
    }

}
