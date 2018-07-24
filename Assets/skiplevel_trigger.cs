using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skiplevel_trigger : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Application.Quit(); // for the demo
    }
}
