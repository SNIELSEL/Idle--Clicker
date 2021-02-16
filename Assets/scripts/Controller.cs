using UnityEngine;
using TMPro;
using System;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    public Data data = new Data();

    public TMP_Text CoinsText;

   public void start()
    {
    }

    public void Update()
    {
        CoinsText.text = $"{data.coins}";
    }

    public void GenerateCoins()
    {
        data.coins += 1;
    }
}
