using UnityEngine;

public class StartPlayingSongOnScene : ChoosenSong
{
    [field: SerializeField] public AudioClip AudioClip;

    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Music");
        if (obj.Length> 1) {
        Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            GetComponent<AudioSource>().clip = GlobalControl.MainAudioClip;
            GetComponent<AudioSource>().Play();
        }
    }

    //private static ChooseSong instance;

    //private void Awake()
    //{
    //    if (instance != null && instance != this)
    //    {
    //        Destroy(this);
    //        return;

    //    }
    //    else
    //    {
    //        instance=this;
    //    }

    //    DontDestroyOnLoad(gameObject);
    //}

    //public void Start()
    //{
    //    if (!GetComponent<AudioSource>().isPlaying)
    //    {
    //        GetComponent<AudioSource>().Play();
    //    }
    //}

    //public void TurnMusicOff()
    //{
    //    if(instance != null)
    //    {
    //        Destroy(this);
    //        instance = null;
    //    }
    //}

    //public void OnApplicationQuit()
    //{
    //    instance = null;
    //}
}