using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatLogic : MonoBehaviour
{
    public GameObject Attacker;
    public GameObject Defender;

    public bool attackerCheck;
    public bool defenderCheck;

    public int attackerSoldier;
    public int defenderSoldier;
    private int newSoldier;
    void Start()
    {
        
    }

    
    void Update()
    {
        UpdateGameObjects();

        if (Input.GetKeyDown(KeyCode.S))
        {
            Combat();
        }
    }

    void Combat()
    {
        newSoldier = attackerSoldier - defenderSoldier;
        Attacker.gameObject.GetComponent<GroundStats>().soldier = newSoldier;
        Defender.gameObject.GetComponent<GroundStats>().soldier = 0;

    }
    void UpdateGameObjects()
    {
        
    }
}
