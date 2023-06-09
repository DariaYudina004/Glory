using UnityEngine;
using System;
using static UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator;

public class Ball : MonoBehaviour
{

    //public static Action onTouched;
    [SerializeField] private int countofHit;
    private void OnCollisionEnter(Collision collision)
    {
        
        Mic mic = collision.gameObject.GetComponent<Mic>();
        if (collision.gameObject.GetComponent<Mic>())
        {
            mic.Hit();
            countofHit ++;

        }
    }
}
