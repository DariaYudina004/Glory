using UnityEngine;

public class Ball : MonoBehaviour
{
    private int count = 0;
    public int Count { get { return count; } set { count = value; } }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bullet hit");

        Mic mic = collision.gameObject.GetComponent<Mic>();
        if (collision.gameObject.GetComponent<Mic>())
        {
            Count++;
            Debug.Log("hit");
            Debug.Log(Count);
            Debug.Log("Количество отбитых шаров" + count);


        }
    }
}
