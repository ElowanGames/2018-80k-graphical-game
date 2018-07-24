using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_game_on_click : MonoBehaviour {

    void OnMouseDown()
    {
        Application.Quit();
    }
}
