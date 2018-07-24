using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_to_loc : MonoBehaviour
{
    // The target marker.
    public Transform target;

    // Speed in units per sec.
    public float speed;
    public bool isClickedOn = false;
    public float delta = 999;

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;
        delta = target.position.x - transform.position.x - 1;
        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
