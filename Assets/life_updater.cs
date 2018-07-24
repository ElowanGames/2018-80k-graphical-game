using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class life_updater : MonoBehaviour {
    Text txt;
    int nextNum = 2;

    // Use this for initialization
    void Start () {
        txt = gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateLife()
    {
        if (nextNum > 0)
        {
            txt.text = "" + nextNum;
            nextNum--;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            // game over screen should occur
        }
    }
}
