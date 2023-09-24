using TMPro;
using UnityEngine;

public class CounterOnPanel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textToEditUI;
    [SerializeField] TextMeshProUGUI missedBalls;

    [SerializeField] private Health healthNow;
    private Ball ball;


    private int countOfHittBall;
    private int countOfMisstBall;

    private void Awake()
    {
        MissBalls();
        ChangeText();
    }

    public void MissBalls()
    {

        countOfMisstBall = 100 - healthNow.HealthOfPlayer;
        Debug.Log("Здоровье в мисс бол " + healthNow.HealthOfPlayer);
        missedBalls.text = countOfMisstBall.ToString();
    }
    public void ChangeText()
    {
        Debug.Log("Количество шаров в ChangeText" + ball.Count);
        countOfHittBall = ball.Count;
        textToEditUI.text = countOfHittBall.ToString();
    }
}
