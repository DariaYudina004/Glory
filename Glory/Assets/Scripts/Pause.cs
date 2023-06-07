using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    
    [SerializeField] Transform player;
    [SerializeField] private GameObject panel;
        
    void Update()
    {
        if (player.position.x >= 50)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            
        }
        
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
        var posPlayer = player.position;
        posPlayer.x -= 50;
        player.position = posPlayer;
        
    }
    public void ExitLevel()
    {
        SceneManager.LoadScene(0);
    }

}
