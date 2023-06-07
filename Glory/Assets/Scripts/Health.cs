using UnityEngine;


public class Health : MonoBehaviour
{
    public int healthOfPlayer = 3;
    [SerializeField] private GameObject panel;

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        EndOfGame end = new EndOfGame();
        if (collision.gameObject.GetComponent<Ball>())
        {
            if (healthOfPlayer > 100) { healthOfPlayer = 100; }
            
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


        }
    }
}
