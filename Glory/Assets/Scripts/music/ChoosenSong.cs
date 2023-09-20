using UnityEngine;

public class ChoosenSong : MonoBehaviour
{
    public SongItemsConfig SongItemsConfig;

    private void Start()
    {
        
    }
    public void ChooseSong()
    {
        Debug.Log("Внутри метода");
        foreach (var songItems in SongItemsConfig.songItems)
        {
            if (songItems.ID == "Sos")
            {
                Debug.Log("sos");
                songItems.SongOnStage.Play();

            }
            if (songItems.ID == "Applause")
            {
                Debug.Log("Applause");
                songItems.SongOnStage.Play();
            }
            if (songItems.ID == "BlindingLights")
            {
                Debug.Log("BlindingLights");
                songItems.SongOnStage.Play();
            }
            if (songItems.ID == "ShapeofYou")
            {
                Debug.Log("ShapeofYou");
                songItems.SongOnStage.Play();
            }
            if (songItems.ID == "CoutingStars")
            {
                Debug.Log("CoutingStars");
                songItems.SongOnStage.Play();
            }
            Debug.Log("Внутри форич");
        }
        Debug.Log("Вышли из форича");
    }
}
