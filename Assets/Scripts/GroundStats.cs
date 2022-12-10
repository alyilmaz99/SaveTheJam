using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundStats : MonoBehaviour
{

    [SerializeField] private int gold;
    [SerializeField] private int science;
    [SerializeField] private int soldier;
    [SerializeField] private int color;

    [SerializeField] private int listIndex;

    [SerializeField] GroundControl groundControl;



    void Awake()
    {
        groundControl.GoldList.Add(gold);
        groundControl.ScienceList.Add(science);
        groundControl.SoldierList.Add(soldier);
        groundControl.ColorList.Add(color);

        listIndex = groundControl.GoldList.Count-1;
    }

    void Update()
    {
        groundControl.GoldList[listIndex]=gold;
        groundControl.ScienceList[listIndex]=science;
        groundControl.SoldierList[listIndex] = soldier;
        groundControl.ColorList[listIndex]=color;
    }
}
