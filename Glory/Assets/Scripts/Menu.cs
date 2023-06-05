using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



    public void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
