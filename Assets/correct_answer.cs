using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correct_answer : MonoBehaviour
{
    private void OnMouseDown()
    {
        level_checker check = this.GetComponent<level_checker>();
        if (check.isClickable)
        {
            GameObject.Find("iphone_background").GetComponent<current_level>().UpdateLevel();
            GameObject.Find("Text").GetComponent<game_2_timer>().UpdateTime();
        }
    }
}
