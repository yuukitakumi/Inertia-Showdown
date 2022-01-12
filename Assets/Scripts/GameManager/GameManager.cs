using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int counter;
    public void Start()
    {
        DontDestroyOnLoad(this);
    }
   
}
