﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public int counter;

    public void Start()
    {
        DontDestroyOnLoad(this);
    }
}
