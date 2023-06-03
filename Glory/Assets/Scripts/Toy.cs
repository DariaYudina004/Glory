using UnityEngine;

public class Toy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Mic mic = collision.gameObject.GetComponent<Mic>();
        if (collision.gameObject.GetComponent<Mic>())
        {
            mic.Hit();
        }
    }
}
