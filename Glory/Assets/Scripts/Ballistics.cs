using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistics : MonoBehaviour
{
    public Transform SpawnTransform;
    public Transform TargetTransform;

    public float AngleInDegrees;
    float g = Physics.gravity.y;

    public GameObject Toy;
    private float v;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot(); 
    }

    public void Shoot()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;
        float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));


        for (int i = 0; i < 10; i++)
        {
            GameObject newToy = Instantiate(Toy, SpawnTransform.position, Quaternion.identity);
            newToy.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;

            if (transform.position.y == 0)
            {
                Destroy(newToy);
                i--;
            }
        }
       

    }
}
