using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    private n
    public AudioSource myFX;
    public AudioClip hoverFx;
    public void HoverSound()
    {
        myFX.PlayOneShot(hoverFx);
    }

}