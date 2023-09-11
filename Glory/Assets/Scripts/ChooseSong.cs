using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSong : MonoBehaviour
{
    [SerializeField] AudioSource song;
    [SerializeField] List<AudioSource> playSongOnScene; 
    [SerializeField] Button continueButton; 
    //[SerializeField] int songIndex = 0;
    //[SerializeField] int indexSongInList;
    //[SerializeField] List<Button> buttons;

    private void Start()
    {
        continueButton.onClick.AddListener(ChooseSongForPlay);
        song.Stop();
       
    }
    public void ChooseSongForPlay()
    {
        NumberOfSong numberOfSong = new NumberOfSong();
        int currentballIndex = PlayerPrefs.GetInt("Current", 0);
        if(currentballIndex == numberOfSong.songIndex)
        {
            song = playSongOnScene[numberOfSong.songIndex];
            GlobalControl.Song = song;
        }
        PlayerPrefs.SetInt("Current", numberOfSong.songIndex);

        //Debug.Log("SongIndex" + numberOfSong.songIndex);
        //for (int i = 0; i < playSongOnScene.Count; i++)
        //{
        //    if (playSongOnScene[i] == numberOfSong.songIndex)
        //    {

        //    }
        //}
        //Debug.Log("SongIndex" + numberOfSong.songIndex);
        //song = playSongOnScene[numberOfSong.songIndex];
        //Debug.Log("SongIndex" + numberOfSong.songIndex);
        //GlobalControl.Song = song;
        //Debug.Log("SongIndex" + GlobalControl.Song);

    }


}
//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.UI;

//public class ChooseSong : MonoBehaviour
//{
//    [SerializeField] AudioSource song;
//    [SerializeField] List<AudioSource> playSongOnScene;
//    [SerializeField] int songIndex = 0;
//    [SerializeField] int indexSongInList;
//    [SerializeField] List<Button> buttons;



//    public void ChooseSongForPlay()
//    {
//        for (int i = 0; i < indexSongInList; i++)
//        {

//            indexSongInList = playSongOnScene.IndexOf(playSongOnScene[i]);
//            if (indexSongInList == songIndex)
//            {
//                song = playSongOnScene[indexSongInList];
//                GlobalControl.Song.clip = song.clip;

//            }
//        }
//        buttons.IndexOf(buttons[indexSongInList]);

//    }

//}
