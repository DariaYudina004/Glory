using UnityEngine;

public class SS : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private float time = 0;
    [SerializeField] private int count = 0;
    private float randomX;

    private float randomZ;
    [SerializeField] Transform SpawnTransform;
    [SerializeField] Transform TargetTransform;

    public float AngleInDegrees;
    float g = Physics.gravity.y;
    [SerializeField] private float v;

    //Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        //float x = fromToXZ.magnitude;
        //float y = fromTo.y;
        //float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
        //float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
        //float v = Mathf.Sqrt(Mathf.Abs(v2));
        time = Time.deltaTime + time;
        if (time > 1 )
        {
            randomX = Random.Range(SpawnTransform.position.x - 15, SpawnTransform.position.x + 15);
            randomZ = Random.Range(SpawnTransform.position.z - 15, SpawnTransform.position.x + 15);
            Vector3 whereToSpawn = new Vector3(randomX, SpawnTransform.position.y, randomZ);
            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            Enemy.GetComponent<Rigidbody>().velocity = transform.forward * 50 ;
            count++;


            Destroy(Enemy, 5);
            time = 0;
        }
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;

//public class Spawner : MonoBehaviour
//{
//    [SerializeField] private GameObject obj;
//    private float randomX;
//    Vector3 whereToSpawn;
//    private float randomZ;
//    [SerializeField] private float timeFromSpawn = 0.0f;





//    // Start is called before the first frame update
//    void Start()
//    {


//        StartCoroutine(Spawn());


//    }

//    IEnumerator Spawn()
//    {
//        yield return new WaitForSeconds(2);
//        if (Time.deltaTime > 0)
//        {
//            timeFromSpawn = Time.deltaTime + timeFromSpawn;

//            if (timeFromSpawn >= 1)
//            {

//                randomX = Random.Range(-100, 100);
//                randomZ = Random.Range(-70, 70);
//                whereToSpawn = new Vector3(randomX, randomZ, transform.position.y);
//                GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);

//                Repeat();
//                Destroy(Enemy, 2);

//                timeFromSpawn = 0;


//            }




//        }
//    }

//    void Repeat()
//    {
//        StartCoroutine(Spawn());
//    }
//}
