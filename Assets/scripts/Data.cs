using System;
using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using UnityEngine.UI;


public class Data
{
    public BigDouble coins;
    public Text coinsText;

    public BigDouble clickUpgradeLevel;

    public Data()
    {
        clickUpgradeLevel = 0;
        coinsText.text = $"You have {coins.ToString("F2")}";
        coins = 0;
    }
}