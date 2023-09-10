using UnityEngine;


public class Health : MonoBehaviour
{
    public int healthOfPlayer = 100;
   
    [SerializeField] private GameObject panel;

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        Debug.Log(healthOfPlayer);
        Debug.Log(healthOfPlayer);
        if (collision.gameObject.GetComponent<Ball>())
        {
            Debug.Log(healthOfPlayer);
            Debug.Log(healthOfPlayer);

            if (healthOfPlayer < 0) 
            {
                healthOfPlayer = 0;
            }

            else if (healthOfPlayer == 0) 
            {
                panel.gameObject.SetActive(true);
                Time.timeScale = 0;
            }

            else healthOfPlayer -= 1;
            Debug.Log(healthOfPlayer);
            Debug.Log(healthOfPlayer);

        }
    }
}
