using UnityEngine;

public class StartPlayingSongOnScene : ChoosenSong
{
    [field: SerializeField] public AudioClip AudioClip;
    [SerializeField] private GameObject panel;
    [SerializeField] private float time = 0;

    

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
    private void Update()
    {
        time += Time.deltaTime;
        if (time > GlobalControl.MainAudioClip.length + 2)
        {

            panel.gameObject.SetActive(true);
            Time.timeScale = 0;
            AudioListener.pause = false;
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