using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] int coins;
    [SerializeField] TextMeshProUGUI MoneyText;

    void Start()
    {
        UpdateMoney();
    }

    public void UpdateMoney()
    {
        Ball coin = GetComponent<Ball>();
        coins = PlayerPrefs.GetInt("Money", coin.Count);
        MoneyText.text = coins.ToString();
    }

}
