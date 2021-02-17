using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class UpgradesManager : MonoBehaviour
{
    public Controller controller;
    public Data Data;
    public Upgrades clickUpgrades;

    public string clickUpgradeName;

    public BigDouble clickUpgradeBaseCost;
    public BigDouble clickUpgradeCostMult;

    public void StartUpgradeManager()
    {
        clickUpgradeName = "Coin Per Click";
        clickUpgradeBaseCost = 10;
        clickUpgradeCostMult = 1.5;
        UpdateClickUpgradeUI();
    }

    public void UpdateClickUpgradeUI()
    {
        clickUpgrades.LevelText.text = controller.data.clickUpgradeLevel.ToString();
        clickUpgrades.CostText.text = "Cost: " + Cost().ToString( format: "F2") + "Coins";
        clickUpgrades.NameText.text = "+1 " + clickUpgradeName;

    }

    public BigDouble Cost() => clickUpgradeBaseCost * BigDouble.Pow(clickUpgradeCostMult, controller.data.clickUpgradeLevel);

    public void BuyUpgrade()
    {
        if (controller.data.coins >= Cost())
        {
            controller.data.coins -= Cost();
            controller.data.clickUpgradeLevel += 1;

            UpdateClickUpgradeUI();
        }

    }
}