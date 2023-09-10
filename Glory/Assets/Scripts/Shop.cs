using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] int ballPrice = 200;
    [SerializeField] Button buyButton;
    [SerializeField] TextMeshProUGUI status;
    [SerializeField] GameObject colorsOfBalls;
    [SerializeField] int ballIndex = 0;
    private int addObjects;

    private ShopManager manager;

    [SerializeField] private GameObject noMoneyMessage;



    void Start()
    {
        buyButton.onClick.AddListener(BuyBall);
        PlayerPrefs.SetInt("BallBought" + 0, 1);

        UpdateInfo();
    } 

    public void SetManager(ShopManager shopManager)
    {
        manager = shopManager;
    }

    public void UpdateInfo()
    {
        int currentBallIndex = PlayerPrefs.GetInt("CurrentBall", 0);
        if (currentBallIndex == ballIndex)
        {
            status.text = "Выбрана";
        }
        else if(PlayerPrefs.GetInt("BallBought" + ballIndex, 0) == 1)
        {
            status.text = "Куплена";
        }
        else
        {
            status.text =  ballPrice.ToString();
        }
    }

    public void BuyBall()
    {
        Ball count = GetComponent<Ball>();
        //int money = PlayerPrefs.GetInt("Money",count.count);
        int money = PlayerPrefs.GetInt("Money",1000);

        if (PlayerPrefs.GetInt("BallBought" + ballIndex, 0) != 1)
        {
            if (money >= ballPrice)
            {
                money -= ballPrice;
                PlayerPrefs.SetInt("Money", money);
                PlayerPrefs.SetInt("BallBought" + ballIndex, 1);

                
                Generation add = new Generation();
                add.ball.Add(gameObject);

                manager.UpdateInfoButton();
            }
            else
            {
                status.text = "Не хватает монет";
            }

        }
        else
        {
            Debug.Log("Куплено ");
            PlayerPrefs.SetInt("CurentBall", ballIndex);
            manager.UpdateInfoButton();
        }
    }
}
