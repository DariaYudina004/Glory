using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] protected int countofHit;
    [SerializeField] protected int count;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bullet hit");

        Mic mic = collision.gameObject.GetComponent<Mic>();
        if (collision.gameObject.GetComponent<Mic>())
        {
            countofHit++;
            Debug.Log("hit");
            Debug.Log(countofHit);
            count = countofHit;
        }
    }
}
