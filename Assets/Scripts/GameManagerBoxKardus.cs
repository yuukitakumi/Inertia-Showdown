using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBoxKardus : MonoBehaviour
{
    public int counter;

    public void Start()
    {
        DontDestroyOnLoad(this);
    }
}
