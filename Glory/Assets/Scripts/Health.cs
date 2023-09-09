using UnityEngine;


public class Health : MonoBehaviour
{
    public int healthOfPlayer;
    [SerializeField] private GameObject panel;

    private void Start()
    {
        healthOfPlayer = GlobalControl.healthOfPlayer;
        Debug.Log(healthOfPlayer);
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        
        if (collision.gameObject.GetComponent<Ball>())
        {
            if (healthOfPlayer > 1000) { healthOfPlayer = 1000; }
            
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
