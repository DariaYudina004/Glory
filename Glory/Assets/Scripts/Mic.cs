using UnityEngine;
using System;

public class Mic : MonoBehaviour
{
    //public static Action onTouched;
    //public static Action onHit;

    //private void OnCollisionEnter(Collision collision)
    //{
    //    onTouched?.Invoke();
    //    onHit?.Invoke();
    //}

    public void Hit()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        GetComponent<Rigidbody>().AddTorque(100,0, 0);
    }
}
