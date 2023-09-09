using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterOnPanel : Ball
{
    //[SerializeField] TextMeshPro textToEdit;
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
        countOfMisstBall = 1000 - GlobalControl.healthOfPlayer;
        missedBalls.text = countOfMisstBall.ToString();
    }
    public void ChangeText()
    {
        countOfHittBall = GlobalControl.countofHit;
        textToEditUI.text = countOfHittBall.ToString();
    }
}
