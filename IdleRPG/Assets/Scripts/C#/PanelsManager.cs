using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsManager : MonoBehaviour {

    [Header("References")]
    public PanelManager panManager;

    [Header("Panels")]
    public GameObject abilityTreePanel;
    public GameObject upgradePanel;
    public GameObject valuesPanel;

    [Space]
    public GameObject choosePanels;

    [Header("Values")]
    public int i;

    void Awake()
    {
        panManager.valuesPanel.SetActive(true);
    }
    public void ChangePanel ()
    {
        // Choose false - Upgrade true //
        if (i == 1)
        {
            panManager.choosePanels.SetActive(false);
            panManager.upgradePanel.SetActive(true);
        }
        // Choose false - Ability true //
        if (i == 2)
        {
            panManager.choosePanels.SetActive(false);
            panManager.abilityTreePanel.SetActive(true);
        }
        // Choose true - Upgrade false //
        if (i == 3)
        {
            panManager.choosePanels.SetActive(true);
            panManager.upgradePanel.SetActive(false);
        }
        // Choose true - Ability false //
        if (i == 4)
        {
            panManager.choosePanels.SetActive(true);
            panManager.abilityTreePanel.SetActive(false);
        }
    }
}