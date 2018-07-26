using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wrong_answer : MonoBehaviour {

    private void OnMouseDown()
    {
        level_checker check = this.GetComponent<level_checker>();
        print("test");
        if (check.isClickable)
        {
            print("what");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
