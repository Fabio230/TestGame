using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [Header("References")]
    private Manager manager;

    [Header("Stats")]
    public float damage;
    public float str, agi, wis, luck; //str=damage/agi=critdamage/wis=magic/luck=crit%
    public float critDamage;

    [Header("Valutes")]
    public float gold;
    public float gems;


    [Header("Levels")]
    public int exp;
    public int currentLevel;
    public int nextLevel;
    public int toLevelUp;
    public float[] levels;

    [Header("Values")]
    public int skillPoint;

    void Awake()
    {
        

    }

    void Update()
    {
        
        if (exp >= levels[currentLevel])
        {
            manager.bar1.i++;
            
        }

    }

}
