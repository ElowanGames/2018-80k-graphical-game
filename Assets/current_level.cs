using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class current_level : MonoBehaviour
{
    public int the_level = 1;

    // Use this for initialization
    private void UpdateLevel()
    {
        the_level++;
    }
}
