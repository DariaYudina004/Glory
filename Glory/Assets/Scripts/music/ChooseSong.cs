using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSong : MonoBehaviour
{
    [SerializeField] AudioSource song;

    public void SOS()
    {
        GlobalControl.Song = song;
        UnityEngine.Debug.Log(song);
    }
    public void Applause()
    {
        GlobalControl.Song = song;
        UnityEngine.Debug.Log(song);
    }
    public void BlindingLights()
    {
        GlobalControl.Song = song;
        UnityEngine.Debug.Log(song);
    }
    public void ShapeofYou()
    {
        GlobalControl.Song = song;
        UnityEngine.Debug.Log(song);
    }
    public void CountingStars()
    {
        GlobalControl.Song = song;
        UnityEngine.Debug.Log(song);
    }
}