using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_2_timer : MonoBehaviour {
    int nextTime = 300;
    int index = 0;
    int[] times = {500, 700};
    Text txt;
	// Use this for initialization
	void Start () {
        txt = gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        if (nextTime > 0)
        {
            if (nextTime % 100 == 0)
            {
                txt.text = "Reply Time: " + nextTime / 100 + "s";
            }
            nextTime--;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            // game over screen should occur
        }
    }

    public void UpdateTime()
    {
        if (index < 2)
        {
            nextTime = times[index];
            index++;
        } else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
