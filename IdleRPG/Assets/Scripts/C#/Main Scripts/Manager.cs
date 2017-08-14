using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour {

	[Header("Player Reference")]
	private Player player;

	[Header("Enemies References")]
	private EnemyGreenSlime enemyGreenSlime;
    public GameObject greenSlime;
    public Transform killCountBar;

    [Header("Other References")]
    public Bar5 bar5;
    public Bar4 bar4;
    public Bar3 bar3;
    public Bar2 bar2;
    public Bar1 bar1;

    [Header("Texts")]
	public Text enemyKillCountText;
	public Text enemyHp;
	public Text enemyName;

    [Header("Skills")]
    public float bonusDamage;
    public float bonusLuck;

    [Header("Values etc..")]
    public Transform Spawnpoint;
    public float killCount;
    public bool isDead;
    public bool upgraded;
    public bool hasSkillpoints;
    private int i = 1;
    [Space]
    // countBD = countBonusDamage //
    public int count;
    public int countBD;

    [Header("Crit Chance")]
    public float targetValue = 0.1f;
    public float randValue;

    [Header("Gems")]
    public float targetGemValue = 0.05f;
    public float randGemValue;

    [Header("ExpBar")]
    public Transform mainBar;
    // Exp that will be divided //
    public float expPercentage;
    // Yellow Bar Counter //
    public int yellowBarCounter;

    void Awake () {

        // Bool Upgraded //
        upgraded = false;

		// Spawn First Enemy //
        if (killCount >= 0 && killCount <= 10)
        {
            if (isDead == true)
            {
            greenSlime = Instantiate(greenSlime, new Vector3(i * 2.0f, 0, 0), Spawnpoint.rotation) as GameObject;
            greenSlime.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            isDead = false;
			}
        }

		// Find Player //
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();

		// Set Booleans //
		isDead = true;
    }

	void Update () {

        // Bonus Damage //
        if (count >= 1 && upgraded == true)
        {
            countBD = count * 5;
            bonusDamage = player.damage / 100 * countBD;
            player.damage = player.damage + bonusDamage;
            upgraded = false;
        }

        // Bool hasSkillpoints //
        if (player.skillPoint >= 1)
        {
            hasSkillpoints = true;
        }

        // Luck Manager //
        player.luck = targetValue * 100f;

        // Random Values //
        randValue = Random.value;
        randGemValue = Random.value;

        // Get Enemies //
        greenSlime = (GameObject)Resources.Load("Prefabs/GreenSlime", typeof(GameObject));

		// Find Texts //
        enemyHp = GameObject.Find("EnemyHpText").GetComponent<Text>();
        enemyName = GameObject.Find("EnemyNameText").GetComponent<Text>();
        enemyKillCountText = GameObject.Find("EnemyKillCountText").GetComponent<Text>();

        // Spawn Enemies //
        if (killCount >= 0 && killCount <= 1000)
        {
            if (isDead == true)
            {
                greenSlime = Instantiate(greenSlime, new Vector3(i * 2.0f, 0, 0), Spawnpoint.rotation) as GameObject;
                greenSlime.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                isDead = false;

            }
        }

        // Take Enemies //
        enemyGreenSlime = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyGreenSlime>();

        // Spawn  Enemies //
        if (killCount >= 0 && killCount <= 10)
        {
            if (isDead == true)
            {
            greenSlime = Instantiate(greenSlime, new Vector3(i * 2.0f, 0, 0), Spawnpoint.rotation) as GameObject;
            greenSlime.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            isDead = false;
            }
        }

        // Enemy Texts //
        enemyName.text = enemyGreenSlime.gsName;
		enemyHp.text = enemyGreenSlime.currentHealth.ToString("F2") + " / " + enemyGreenSlime.Health.ToString("F0");

        // Killcount //
        killCountBar.GetComponent<Image>().fillAmount = killCount / 10f;
        enemyKillCountText.text = killCount + " out of 10";

        // Exp % Calculator //
        expPercentage = (player.exp * 100) / player.levels[player.currentLevel];

        // Exp Bar //
        mainBar.GetComponent<Image>().fillAmount = expPercentage / 100;

        // Experience Bar Manager //
        if (bar5.i == 2)
        {
            bar5.i = 0;
            bar4.i = 0;
            bar3.i = 0;
            bar2.i = 0;
            bar1.i = 0;
            player.currentLevel++;
        }

    }

}