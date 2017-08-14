using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGreenSlime : MonoBehaviour {

	public Player player;
	public Manager manager;

	public float Health = 10;
	public float currentHealth;
	public float givenGold = 1;
	public int givenExp = 5;
    public int givenGem = 1;
    public int i;

    public string gsName = "Green Slime";

	void Start () {

        i = 3;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();

        Health = Health + (manager.killCount * i);

        currentHealth = Health;
    }

	void Update () {

		if (currentHealth <= 0) {
			player.gold += givenGold;
			player.exp += givenExp;

			manager.isDead = true;

			manager.killCount++;
			Destroy(gameObject);

            if (manager.randGemValue < (manager.targetGemValue))
            {
                player.gems += givenGem;
                Debug.Log("You got a gem!");
            }

			manager.enemyHp.text = gsName + "\n" + currentHealth + "/" + Health;
		}
	}

    public void Clicked ()
    {
        if (manager.randValue < (manager.targetValue))
        {
            currentHealth -= player.critDamage;
            Debug.Log("You have landed a Critical Strike");
        }
        else
        {
            currentHealth -= player.damage;
        }
	}
}
