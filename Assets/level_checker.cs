using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_checker : MonoBehaviour
{
    public int level;
    public bool isClickable = false;

    // Use this for initialization
    void Start()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        var curr = GameObject.Find("iphone_background").GetComponent<current_level>();
        if (level < curr.the_level)
        {
            Destroy(gameObject);
        }
        if (level == curr.the_level && !isClickable)
        {
            this.GetComponent<BoxCollider2D>().enabled = true;
            isClickable = true;
            
            Color tmp = this.GetComponent<SpriteRenderer>().color;
            tmp.a = 255f;
            this.GetComponent<SpriteRenderer>().color = tmp;
        }
    }
}