using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float time;
    public Text timer;

    void Update()
    {
        if (Time.time >= time + 1f)
        {
            //code something
            time = Time.time;
        }

        timer.text = time.ToString("F0") + "";
    }
}