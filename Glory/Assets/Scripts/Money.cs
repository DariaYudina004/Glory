using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] int coins;
    [SerializeField] int coinsOfHit;
    [SerializeField] TextMeshProUGUI MoneyText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateMoney();
    }
    public void UpdateMoney()
    {

        coins = PlayerPrefs.GetInt("Money", coins);
        MoneyText.text = coins.ToString();
    }





}
