using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_checker : MonoBehaviour
{
    public int level;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var curr = GameObject.Find("name here").GetComponent<current_level>();
        if (level < curr.the_level)
        {
            Destroy(gameObject);
        }
    }
}