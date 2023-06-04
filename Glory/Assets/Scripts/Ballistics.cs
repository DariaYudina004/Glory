//using UnityEngine;

//public class Ballistics : MonoBehaviour
//{
//    public Transform SpawnTransform;
//    public Transform TargetTransform;

//    public float AngleInDegrees;
//    float g = Physics.gravity.y;
//    GameObject en;

//    protected float v;

//    // Update is called once per frame
//    void Update()
//    {
//    }

//    public void Shoot()
//    {

//        Vector3 fromTo = TargetTransform.position - transform.position;
//        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

//        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

//        float x = fromToXZ.magnitude;
//        float y = fromTo.y;
//        float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
//        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
//        float v = Mathf.Sqrt(Mathf.Abs(v2));


//        en = GameObject.FindGameObjectWithTag("Enemy");
//        en.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;

//    }
//}






//void Update()
//{
//    StartCoroutine(Shoot());
//}

//IEnumerator Shoot()
//{
//    yield return new WaitForSecondsRealtime(5);
//    Vector3 fromTo = TargetTransform.position - transform.position;
//    Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

//    transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

//    float x = fromToXZ.magnitude;
//    float y = fromTo.y;
//    float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
//    float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
//    float v = Mathf.Sqrt(Mathf.Abs(v2));





//    GameObject newToy = Instantiate(Toy, SpawnTransform.position, Quaternion.identity);
//    newToy.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;

//    Repeat();
//    Destroy(newToy);

//}

//void Repeat()
//{
//    StartCoroutine(Shoot());
//}
//}




//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Ballistics : MonoBehaviour
//{
//    public Transform SpawnTransform;
//    public Transform TargetTransform;

//    public float AngleInDegrees;
//    float g = Physics.gravity.y;

//    [SerializeField] private GameObject Toy;
//    protected float v;

//    [SerializeField] private float time = 0;
//    [SerializeField] private int count = 0;
//    [SerializeField] private GameObject obj;

//    private float randomX;

//    private float randomZ;





//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Shoot();
//    }

//    public void Shoot()
//    {
//        Vector3 fromTo = TargetTransform.position - transform.position;
//        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

//        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

//        float x = fromToXZ.magnitude;
//        float y = fromTo.y;
//        float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
//        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
//        float v = Mathf.Sqrt(Mathf.Abs(v2));

//        time = Time.deltaTime + time;
//        if (time > 0.1)
//        {
//            randomX = Random.Range(-100, 100);
//            randomZ = Random.Range(-70, 100);
//            Vector3 whereToSpawn = new Vector3(randomX, 10, randomZ);
//            GameObject newToy = Instantiate(Toy, SpawnTransform.position, Quaternion.identity) ;
//            newToy.GetComponentInParent<Rigidbody>().velocity = SpawnTransform.forward * v;
//            count++;


//            Destroy(newToy, 20);
//            time = 0;
//        }

//    }
//}
using UnityEngine;

public class Ballistics : MonoBehaviour
{
    [SerializeField] Transform SpawnTransform;
    [SerializeField] Transform TargetTransform;

    public float AngleInDegrees;
    float g = Physics.gravity.y;

    [SerializeField] private GameObject obj;
    [SerializeField] private float time = 0;
    [SerializeField] private int count = 0;
    private float randomX;
    private float randomZ;

    protected float v;

    private void Start()
    {
        SpawnTransform = GetComponent<Transform>(); 
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;
        float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));

        time = Time.deltaTime + time;
        if (time > 2)
        {

            GameObject Enemy = Instantiate(obj, transform.position, Quaternion.identity);
            count++;
            Enemy.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;

            Destroy(Enemy, 5);
            time = 0;
        }
    }

    public void Shoot()
    {

        

    }
}
