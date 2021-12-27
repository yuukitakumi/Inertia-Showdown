using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class Patung : ScriptableObject
{
    [Header("initial")]
    public Vector2 patungPosition;
    [Header("New")]
    public Vector2 patungPositionNew;

    private void Awake()
    {
        patungPosition = patungPositionNew;
    }
    private void OnDisable()
    {
        patungPositionNew = patungPosition;
    }
}

