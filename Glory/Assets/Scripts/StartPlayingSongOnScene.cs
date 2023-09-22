using System.Collections.Generic;
using UnityEngine;

    public class StartPlayingSongOnScene : ChoosenSong
    {
    public void Update()
    {

        Debug.Log(NumberOfSong.AudioClip);
        GetComponent<AudioSource>().PlayOneShot(NumberOfSong.AudioClip);
        Debug.Log("After");
    }

}

