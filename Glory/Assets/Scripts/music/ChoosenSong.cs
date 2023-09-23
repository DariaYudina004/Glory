using UnityEngine;

public class ChoosenSong : MonoBehaviour
{
    public void ChooseSong()
    {
        Debug.Log(GlobalControl.MainAudioClip);
        Debug.Log("Внутри метода");
        //NumberOfSong.AudioClip = GlobalControl.MainAudioClip;

        Debug.Log("Внутри условия");
        GlobalControl.MainAudioClip = GetComponent<AudioSource>().clip ;
        if(gameObject.tag != "AlreadyChoosed")
        {
            gameObject.tag = "AlreadyChoosed";
        }
        gameObject.tag = "AlreadyChoosed";
        Debug.Log("**************");
        Debug.Log(GlobalControl.MainAudioClip);
        Debug.Log("**************");
        Debug.Log("Да");


        //songItems.SongOnStage.PlayOneShot(songItems.ClipOnStage);

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
        Debug.Log("Внутри форич");
    }
    public void NotChoosen()
    {
        if (gameObject.tag != "Music")
        {
            gameObject.tag = "Music";
        }
        
    }

}

