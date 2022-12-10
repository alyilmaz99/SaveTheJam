using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Reflection.Emit;

public class GroundCreate : MonoBehaviour
{
    [SerializeField] Image cityPicture;
    [SerializeField] int goldNumber;
    [SerializeField] int scienceNumber;
    [SerializeField] int menNumber;
    [SerializeField] int menPower;
    [SerializeField] String cityName;
    Dictionary<dynamic, dynamic> map;
    public GroundCreate(int _menNumber, int _scienceNumber, int _menPower, int _goldNumber, Image _cityPicture, string _cityName)
    {
        this.menNumber = _menNumber;
        this.goldNumber = _goldNumber;
        this.scienceNumber = _scienceNumber;
        this.menPower = _menPower;
        this.cityPicture = _cityPicture;
        this.cityName = _cityName;
        addPlayerList();
    }
    public void addPlayerList()
    {
        map.Add("cityPicture", cityPicture);
        map.Add("goldNumber", goldNumber);
        map.Add("scienceNumber", scienceNumber);
        map.Add("menNumber",menNumber);
        map.Add("menPower", menPower);
        map.Add("cityName", cityName);
    }

    private void Start()
    {
        
    }

}
