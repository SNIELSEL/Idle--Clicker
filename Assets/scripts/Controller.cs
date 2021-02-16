using UnityEngine;
using TMPro;
using System;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    public UpgradesManager upgradesManager;
    public Data data = new Data();

    [SerializeField] private TMP_Text CoinsText;
    [SerializeField] private TMP_Text coinClickPowerText;

    public BigDouble ClickPower() => 1 + data.clickUpgradeLevel;

    public void start()
    {
        upgradesManager.StartUpgradeManager;
    }

    public void Update()
    {
        CoinsText.text = $"{data.coins}";
        coinClickPowerText.text = "+" + ClickPower() + "Coins";
    }

    public void GenerateCoins()
    {
        data.coins += ClickPower();
    }
}
