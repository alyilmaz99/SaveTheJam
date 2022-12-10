using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] List<GameObject> Grounds;
    [SerializeField] ProfilePanelController profilePanelController;
    [SerializeField] public int Gold;
    [SerializeField] public int Science;
    [SerializeField] public int Military;
    [SerializeField] public string State;

    void Start()
    {
        profilePanelController.GoldText.text = Gold.ToString();
        profilePanelController.ScienceText.text = Science.ToString();
        profilePanelController.Militarytext.text = Military.ToString();
        profilePanelController.StageText.text = State;
    }

    
    void Update()
    {
        
    }
    
}
