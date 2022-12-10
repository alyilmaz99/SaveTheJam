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
    void Start()
    {
  
        switch (gameController.State)
        {
            case "1.Çað":
                StageImage.sprite = Images[0];
                break;
            case "2.Çað":
                StageImage.sprite = Images[1];
                break;
            case "3.Çað":
                StageImage.sprite = Images[2];
                break;
            case "4.Çað":
                StageImage.sprite = Images[3];
                break;
            case "5.Çað":
                StageImage.sprite = Images[4];
                break;
            default:
                break;
        }
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

    void Update()
    {
        
    }
}
