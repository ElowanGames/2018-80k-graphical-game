using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class word_updater : MonoBehaviour {
    int nextWordIndex = 0;
    string[] wordArray = { "Salty", "Fam", "Gucci", "Low-key"};
    Text txt;
    
	// Use this for initialization
	void Start () {
        txt = gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void UpdateWord()
    {
        if (nextWordIndex < 4)
        {
            txt.text = wordArray[nextWordIndex];
            nextWordIndex++;
        } else
        {
            ending_data.UpdateNum();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
