using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PintuManager : MonoBehaviour
{
    public GameObject players;
    public Vector2 playerPosition;
    public string sceneNama;
    private bool checking;
    void Awake()
    {
        checking = true;
        DontDestroyOnLoad(this);
    }
    // Update is called once per frame
    void Update()
    {
        
        players = GameObject.FindWithTag("Player");
        Scene scene = SceneManager.GetActiveScene();
        string sceneName = scene.name;
        
        if (checking == true && sceneName == sceneNama)
        {
            players.transform.position =  new Vector2(playerPosition.x, playerPosition.y);
            checking = false;
        }
    }
}