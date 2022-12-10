using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField] List<GameObject> Grounds;
    [SerializeField] ProfilePanelController profilePanelController;
    [SerializeField] public int Gold;
    [SerializeField] public int Science;
    [SerializeField] public int Military;
    [SerializeField] public string State;
    [SerializeField] public float timeRemaining = 0;
    [SerializeField] public Text Timer;
    void Start()
    {
        profilePanelController.GoldText.text = Gold.ToString();
        profilePanelController.ScienceText.text = Science.ToString();
        profilePanelController.Militarytext.text = Military.ToString();
    }

    
    void Update()
    {
        if (timeRemaining >= 0)
        {
            
            timeRemaining += Time.deltaTime;
            Timer.text = timeRemaining.ToString();

        }
    }
    
}
