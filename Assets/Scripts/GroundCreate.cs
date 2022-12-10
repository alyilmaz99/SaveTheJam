using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundCreate : MonoBehaviour
{
    [SerializeField] Image cityPicture;
    [SerializeField] int goldNumber;
    [SerializeField] int scienceNumber;
    [SerializeField] int menNumber;
    [SerializeField] int menPower;
    
    GroundCreate(int _menNumber, int _scienceNumber, int _menPower, int _goldNumber, Image _cityPicture)
    {
        this.menNumber = _menNumber;
        this.goldNumber= _goldNumber;
        this.scienceNumber = _scienceNumber;
        this.menPower = _menPower;
        this.goldNumber = _goldNumber;
        this.cityPicture = _cityPicture;
    }
    public void addPlayerList()
    {

    }
}
