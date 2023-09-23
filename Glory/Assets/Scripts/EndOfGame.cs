using UnityEngine;

public class EndOfGame : MonoBehaviour
{
    private Health health;
    [SerializeField] private GameObject panel;

    public void End()
    {
        Debug.Log(health.HealthOfPlayer);
        if (health.HealthOfPlayer <= 0)
        {
            panel.gameObject.SetActive(true);
            Time.timeScale = 0;
            GetComponent<AudioSource>().Stop();
        }
        else if (!GetComponent<AudioSource>().isPlaying)
        {
            panel.gameObject.SetActive(true);
            Time.timeScale = 0;
            GetComponent<AudioSource>().Stop();
        }
    }
}
