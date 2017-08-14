using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour {

    [Header("Panels")]
    public GameObject abilityTreePanel;
    public GameObject upgradePanel;
    public GameObject valuesPanel;

    [Space]
    public GameObject choosePanels;

    void Awake()
    {
        // Panels Manager //
        abilityTreePanel.SetActive(false);
        upgradePanel.SetActive(false);
        valuesPanel.SetActive(true);
        choosePanels.SetActive(true);
    }
}