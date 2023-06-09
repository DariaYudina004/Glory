using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void ExitLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void RepeatLevel()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
