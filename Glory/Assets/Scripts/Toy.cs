using UnityEngine;
using System;
using static UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator;

public class Toy : MonoBehaviour
{
    [SerializeField] private int count = 0;
    //public static Action onTouched;

    private void OnCollisionEnter(Collision collision)
    {
        
        Mic mic = collision.gameObject.GetComponent<Mic>();
        if (collision.gameObject.GetComponent<Mic>())
        {
            mic.Hit();
            count++;

        }
    }
}
