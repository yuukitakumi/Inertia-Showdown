using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueController : MonoBehaviour
{
    public string tap;
    public Vector2 statuePosition;
    public Patung statueStorage;

    void Start()
    {
        transform.position = statueStorage.patungPositionNew;
        statueStorage.patungPositionNew = transform.position;
    }
    void OnDisable()
    {
        statueStorage.patungPositionNew = transform.position;
    }
}
