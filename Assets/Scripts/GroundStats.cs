using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GroundStats : MonoBehaviour
{

    [SerializeField] private int gold;
    [SerializeField] private int science;
    [SerializeField] private int soldier;
    [SerializeField] private int color;

    [SerializeField] private int listIndex;

    [SerializeField] GroundControl groundControl;

    [SerializeField] private TextMeshPro GoldText;
    [SerializeField] private TextMeshPro ScienceText;
    [SerializeField] private TextMeshPro SoldierText;

    [Header("PopUp")]

    public bool mouseCheck=false;
    [SerializeField] private GameObject AttackButton;
    [SerializeField] private GameObject UpgradeButton;


    void Awake()
    {
        groundControl.GoldList.Add(gold);
        groundControl.ScienceList.Add(science);
        groundControl.SoldierList.Add(soldier);
        groundControl.ColorList.Add(color);

        listIndex = groundControl.GoldList.Count-1;
    }

    private void Start()
    {
        AttackButton.SetActive(false);
        UpgradeButton.SetActive(false);
    }

    void Update()
    {
        groundControl.GoldList[listIndex]=gold;
        groundControl.ScienceList[listIndex]=science;
        groundControl.SoldierList[listIndex] = soldier;
        groundControl.ColorList[listIndex]=color;


        GoldText.text = "Gold: "+ gold.ToString();
        ScienceText.text = "Science: "+science.ToString();
        SoldierText.text = "Soldier: "+soldier.ToString();

        PopUp();
    }

    void PopUp()
    {
        if (mouseCheck)
        {
            AttackButton.SetActive(true);
            UpgradeButton.SetActive(true);
        }
        else
        {
            AttackButton.SetActive(false);
            UpgradeButton.SetActive(false);
        }
    }


}
