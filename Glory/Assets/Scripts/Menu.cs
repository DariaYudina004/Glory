using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    
    public void ExitGame()
    {
        Application.Quit();
    }
}
