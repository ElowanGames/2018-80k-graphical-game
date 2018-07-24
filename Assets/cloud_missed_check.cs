using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_missed_check : MonoBehaviour {
    move_to_loc movement;

	// Use this for initialization
	void Start () {
        movement = this.GetComponent<move_to_loc>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!movement.isClickedOn && movement.delta == -1)
        {
            movement.isClickedOn = true;
            GameObject.Find("lives_num").GetComponent<life_updater>().UpdateLife();
            GameObject.Find("header_word").GetComponent<word_updater>().UpdateWord();
        }
    }
}
