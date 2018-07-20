using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cloud_click_correct : MonoBehaviour
{
    public Sprite sun;
    SpriteRenderer sr;

    // Use this for initialization
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Change sprites on click
    void OnMouseDown()
    {
        sr.sprite = sun;
    }
}
