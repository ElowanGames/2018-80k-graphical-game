using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class cloud_click_incorrect : MonoBehaviour, IPointerClickHandler
{
    public Sprite rain;
    Image img;
    Text txt;
    bool isClickedOn = false;

    // Use this for initialization
    void Start()
    {
        img = gameObject.GetComponent<Image>();
        txt = img.GetComponentInChildren<Text>();
    }

    // Change sprites on click
    public void OnPointerClick(PointerEventData eventData)
    {
        img.sprite = rain;
        move_to_loc movement = this.GetComponent<move_to_loc>();
        movement.speed = 0;
        movement.isClickedOn = true;
        isClickedOn = true;
    }

    private void Update()
    {
        if (img.sprite == rain)
        {
            img.CrossFadeAlpha(0, 0.5f, false);
            txt.CrossFadeAlpha(0, 0.5f, false);
        }
        if (isClickedOn)
        {
            isClickedOn = false;
            GameObject.Find("lives_num").GetComponent<life_updater>().UpdateLife();
        }
    }
}
