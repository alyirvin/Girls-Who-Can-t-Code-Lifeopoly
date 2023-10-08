using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Increase10 : MonoBehaviour
{
    public int playerMoneyInt1 = 0;
    public TMP_Text MoneyAmount1;

    [ContextMenu("Increase10 Money")]
    public void addMoney()
    {
        playerMoneyInt1 = playerMoneyInt1 + 10000;
        MoneyAmount1.text = playerMoneyInt1.ToString();
    }

    [ContextMenu("Decrease10 Money")]
    public void lessMoney()
    {
        playerMoneyInt1 = playerMoneyInt1 - 10000;
        MoneyAmount1.text = playerMoneyInt1.ToString();
    }
}
