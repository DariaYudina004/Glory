using UnityEngine;


public class Health : MonoBehaviour
{
    private int healthOfPlayer = 100;
    public int HealthOfPlayer
    {
        get { return healthOfPlayer; }
        set
        {
            if (healthOfPlayer > 0)
            {
                healthOfPlayer = value;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        Debug.Log(HealthOfPlayer);
        Debug.Log(HealthOfPlayer);
        if (collision.gameObject.GetComponent<Ball>())
        {
            Debug.Log(HealthOfPlayer);
            Debug.Log(HealthOfPlayer);

            HealthOfPlayer -= 1;
            Debug.Log(HealthOfPlayer);
            Debug.Log(HealthOfPlayer);

        }
    }
}
