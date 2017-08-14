using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar3 : MonoBehaviour {

    public Player player;
    public Manager manager;
    public Bar4 bar4;

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
            bar4.i++;
        }

        if (i >= 1)
        {
            speed += Time.deltaTime * 5;
            bar.GetComponent<Image>().fillAmount = speed;
        }
        else
        {
            speed = 0.0f;
            bar.GetComponent<Image>().fillAmount = 0;
        }

    }

}
