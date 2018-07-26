using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textContinue2 : MonoBehaviour {
    void OnMouseDown()
    {
        print("Clicked");
        SceneManager.LoadScene("Scene02_Doors1");
    }
}
