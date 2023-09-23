using UnityEngine;

public class EndOfGame : MonoBehaviour
{
    private Health health;
    [SerializeField] private GameObject panel;

    private void Update()
    {
        Debug.Log("Çהמנמגüÿ ג ‎םה מפ דויל" + health.HealthOfPlayer);
        if (health.HealthOfPlayer <= 0)
        {
            panel.gameObject.SetActive(true);
            Time.timeScale = 0;
            AudioListener.pause = true;
        }
        if (AudioListener.pause == true)
        {
            panel.gameObject.SetActive(true);
            Time.timeScale = 0;
            AudioListener.pause = false;
        }
    }
}
