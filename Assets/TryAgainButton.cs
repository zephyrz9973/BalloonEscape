﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    	
    }

    void OnMouseDown() {
       string sceneName = PlayerPrefs.GetString("lastLoadedScene");
       SceneManager.LoadScene(sceneName);//back to previous scene1?
    }
}
