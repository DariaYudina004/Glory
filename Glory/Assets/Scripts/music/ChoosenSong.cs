using UnityEngine;

public class ChoosenSong : MonoBehaviour
{
    public SongItemsConfig SongItemsConfig;
    public NumberOfSong NumberOfSong;

    private void Start()
    {
        
    }
    public void ChooseSong()
    {
        Debug.Log(NumberOfSong.SongIndex);
        Debug.Log(NumberOfSong.AudioClip);
        Debug.Log("������ ������");
        foreach (var songItems in SongItemsConfig.songItems)
        {
            //if (songItems.ID == "Sos")
            //{
            //    Debug.Log("sos");
            //    songItems.SongOnStage.PlayOneShot(songItems.ClipOnStage);
            //}
            if (NumberOfSong.SongIndex == songItems.ID )
            {
                Debug.Log("������ �������");
                GetComponent<AudioSource>().clip = NumberOfSong.AudioClip;
                Debug.Log("**************");
                Debug.Log(NumberOfSong.SongIndex);
                Debug.Log(NumberOfSong.AudioClip);
                Debug.Log("**************");
                Debug.Log("��");
                //songItems.SongOnStage.PlayOneShot(songItems.ClipOnStage);
            }
            //if (songItems.ID == "BlindingLights")
            //{
            //    Debug.Log("BlindingLights");
            //    songItems.SongOnStage.PlayOneShot(songItems.ClipOnStage);
            //}
            //if (songItems.ID == "ShapeofYou")
            //{
            //    Debug.Log("ShapeofYou");
            //    songItems.SongOnStage.PlayOneShot(songItems.ClipOnStage);
            //}
            //if (songItems.ID == "CoutingStars")
            //{
            //    Debug.Log("CoutingStars");
            //    songItems.SongOnStage.PlayOneShot(songItems.ClipOnStage);
            //}
            Debug.Log("������ �����");
        }
        Debug.Log("����� �� ������");
    }
}
