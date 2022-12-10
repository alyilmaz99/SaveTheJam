using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ProfilePanelController : MonoBehaviour
{
    [SerializeField] GameController gameController;
    [SerializeField] public Text StageText;
    [SerializeField] public Image StageImage;
    [SerializeField] public Text GoldText;
    [SerializeField] public Image GoldImage;
    [SerializeField] public Text ScienceText;
    [SerializeField] public Image ScienceImage;
    [SerializeField] public Text Militarytext;
    [SerializeField] public Image MilitaryImage;
    [SerializeField] public List<Sprite> Images;



    public List<GameObject> Red;
    public List<GameObject> Blue;
    public List<GameObject> Natural;

    [SerializeField] GroundControl groundControl;
    void Start()
    {

    }
    void Update()
    {/*
        if (groundControl.ColorList[0]==0)
        {
            Natural.Add(groundControl.Ground);
        }
         else if (groundControl.ColorList[0] == 1)
        {
            Blue.Add(groundControl.Ground);
        }
        else if (groundControl.ColorList[0] == 2)
        {
            Red.Add(groundControl.Ground);
        }*/
    }
    public static Texture2D LoadImage(string filePath)
    {
        Texture2D tex = null;
        byte[] fileData;

        if (File.Exists(filePath))
        {
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
        }
        return tex;
    }

    
}
