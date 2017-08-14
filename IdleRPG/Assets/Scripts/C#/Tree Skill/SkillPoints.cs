using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPoints : MonoBehaviour {

    [Header("References")]
    public Manager manager;
    public Player player;

    [Header("Values")]
    public int l;

    public void upgradeSkill ()
    {
        // Add Bonus Strength //
        if (manager.hasSkillpoints = true && player.skillPoint >= 1)
        {
            manager.count++;
            player.skillPoint--;
            manager.upgraded = true;
        }
    }
}