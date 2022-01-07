using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swiitch : MonoBehaviour
{

    [SerializeField] public GameObject[] strucc;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(index >= 6) index = 6;
        if(index < 0) index = 0;

        if(index == 0){
            strucc[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        index += 1;

        for(int i = 0 ; i < strucc.Length; i++)
        {
            strucc[i].gameObject.SetActive(false);
            strucc[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }

    public void Previous()
    {
        index -= 1;

        for(int i = 0 ; i < strucc.Length; i++)
        {
            strucc[i].gameObject.SetActive(false);
            strucc[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
}
