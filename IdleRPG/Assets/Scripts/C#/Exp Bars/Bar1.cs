using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar1 : MonoBehaviour {

    public Player player;
    public Manager manager;
    public Bar2 bar2;

    public Transform bar;

    public int i;
    public float speed;

    void Awake()
    {
        speed = 0.0f;
    }

    void Update()
    {

        if (i == 2)
        {
            i--;
            bar2.i++;
        }

        if (i >= 1)
        {
            speed += Time.deltaTime * 5;
            bar.GetComponent<Image>().fillAmount = speed;
        }
        else
        {
            speed = 0.0f;
            bar.GetComponent<Image>().fillAmount = 0.0f;
        }

    }

}
