using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    public List<GameObject> AskeriButtonsBlur = new List<GameObject>();
    public List<GameObject> DefansifButtonsBlur = new List<GameObject>();
    public List<GameObject> OzelButtonsBlur = new List<GameObject>();

    public List<int> AskeriSciencePointNeedList = new List<int> ();
    public List<int> DefansifSciencePointNeedList = new List<int>();
    public List<int> OzelSciencePointNeedList = new List<int>();

    [SerializeField] GameController gameController;
    [SerializeField] SkillChart skillChart;
    [SerializeField] private int science;



    void Start()
    {
        
    }

    
    void Update()
    {
        science = gameController.Science;


        DefansifButtonsBlurControl();
        AskeriButtonsBlurControl();
        OzelGucButtonsControl();
    }

    void AskeriButtonsBlurControl()
    {
        for (int i = 0; i<=11; i++)
        {
            if (!skillChart.askeriList[i] && science >= AskeriSciencePointNeedList[i])
            {
                AskeriButtonsBlur[i].gameObject.SetActive(false);
            }
            else if (!skillChart.askeriList[i] && science < AskeriSciencePointNeedList[i])
            {
                AskeriButtonsBlur[i].gameObject.SetActive(true);
            }

            if (skillChart.askeriList[i])
            {
                AskeriButtonsBlur[i].gameObject.SetActive(false);
            }
        }
    }

    void DefansifButtonsBlurControl()
    {
        for (int i = 0; i <= 11; i++)
        {
            if (!skillChart.defansifList[i] && science >= DefansifSciencePointNeedList[i])
            {
                DefansifButtonsBlur[i].gameObject.SetActive(false);
            }
            else if (!skillChart.defansifList[i] && science < DefansifSciencePointNeedList[i])
            {
                DefansifButtonsBlur[i].gameObject.SetActive(true);
            }

            if (skillChart.defansifList[i])
            {
                DefansifButtonsBlur[i].gameObject.SetActive(false);
            }
        }
    }
    void OzelGucButtonsControl()
    {
        for (int i = 0; i <= 11; i++)
        {
            if (!skillChart.ozelList[i] && science >= OzelSciencePointNeedList[i])
            {
                OzelButtonsBlur[i].gameObject.SetActive(false);
            }
            else if (!skillChart.ozelList[i] && science < OzelSciencePointNeedList[i])
            {
                OzelButtonsBlur[i].gameObject.SetActive(true);
            }

            if (skillChart.ozelList[i])
            {
                OzelButtonsBlur[i].gameObject.SetActive(false);
            }
        }
    }
}
