using TMPro;
using UnityEngine;

public class CounterOnPanel : Ball
{
    [SerializeField] TextMeshProUGUI textToEditUI;
    [SerializeField] TextMeshProUGUI missedBalls;


    private int countOfHittBall;
    private int countOfMisstBall;

    private void Start()
    {
        ChangeText();
        MissBalls();
    }

    public void MissBalls()
    {
        Health health = GetComponent<Health>();
        countOfMisstBall = 100 - health.healthOfPlayer;
        Debug.Log(health.healthOfPlayer);
        missedBalls.text = countOfMisstBall.ToString();
    }
    public void ChangeText()
    {
        countOfHittBall = count;
        textToEditUI.text = countOfHittBall.ToString();
    }
}
