using UnityEngine;

public class Mic : MonoBehaviour
{
    // Start is called before the first frame update
    public void Hit()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        GetComponent<Rigidbody>().AddTorque(100,0, 0);
    }
}
