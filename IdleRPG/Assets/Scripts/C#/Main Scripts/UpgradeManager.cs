using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {
    
    [Header("References")]
    public Player player;
    public Manager manager;

    [Header("Values")]
    public float cost, startingCost;
    public float str, addedDamage, addedLuck;
    public int neededLevel;
    public int count;

    [Header("Texts")]
    public Text upgradeText;
    public string upgradeName;

    void Start () {

        // Upgrade Cost //
        startingCost = cost;
        count = 0;

    }
	
	void Update () {
        // Upgrade Text //
        upgradeText.text = "Upgrade Name: " + upgradeName + "\n Cost: " + cost + "\nRequired Lv. : " + neededLevel;
	}

    public void UpgradeDamage ()
        // Upgrade Damage //
    {
        if (player.gold >= cost && player.currentLevel >= neededLevel)
        {
            player.gold -= cost;
            player.damage += addedDamage;

            count++;
            cost = Mathf.Round(startingCost * Mathf.Pow(1.25f, count));
        }
    }

    public void UpgradeStrength()
        // Upgrade Strength //
    {
        if (player.gold >= cost && player.currentLevel >= neededLevel)
        {
            player.gold -= cost;
            player.str += str;

            count++;
            cost = Mathf.Round(startingCost * Mathf.Pow(1.25f, count));
        }
    }

    public void UpgradeLuck()
        // Upgrade Luck //
    {
        if (player.gold >= cost && player.currentLevel >= neededLevel)
        {
            player.gold -= cost;
            manager.targetValue += addedLuck;

            count++;
            cost = Mathf.Round(startingCost * Mathf.Pow(1.25f, count));
        }
    }
}
