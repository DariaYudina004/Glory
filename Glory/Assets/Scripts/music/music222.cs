using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    private Sprite onMusic;
    private Sprite offMusic;

    private Image musicButton;
    private bool isOn;
    private AudioSource ad;

    public Sprite OnMusic { get => onMusic; set => onMusic = value; }
    public Sprite OffMusic { get => offMusic; set => offMusic = value; }
    public Image MusicButton { get => musicButton; set => musicButton = value; }
    public bool IsOn { get => isOn; set => isOn = value; }
    public AudioSource Ad { get => ad; set => ad = value; }

    void Start()
    {
        isOn = true;

    }
    void Update()
    {
        if (PlayerPrefs.GetInt("music") == 0)
        {
            MusicButton.GetComponent<Image>().sprite = onMusic;
            ad.enabled = true;
            isOn = true;
        }
        else if (PlayerPrefs.GetInt("music") == 1)
        {
            MusicButton.GetComponent<Image>().sprite = offMusic;
            ad.enabled = false;
            isOn = false;
        }
    }

    public void offSaund()
    {
        if (!isOn)
        {
            PlayerPrefs.SetInt("music", 0);

        }
        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);

        }
    }

}