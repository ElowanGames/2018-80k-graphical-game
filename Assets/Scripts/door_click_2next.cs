﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door_click_2next : MonoBehaviour {

    void OnMouseDown()
    {
        print("Clicked");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}