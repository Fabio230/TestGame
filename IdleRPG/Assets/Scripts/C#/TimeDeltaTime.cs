using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDeltaTime : MonoBehaviour {

    public float time;
    public float speed;

    void Awake()
    {
        time = 1.0f;
        speed = 2.0f;
    }

    void Update()
    {
        time += speed * Time.deltaTime;
    }
}
