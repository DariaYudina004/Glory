using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    //[SerializeField] private GameObject objects;
    [SerializeField] private float time = 0;
    [SerializeField] private int count = 0;
    private float randomX;

    private float randomZ;
    [SerializeField] Transform TargetTransform;



    //Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    private GameObject SpawnEnemy()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);
        Ballistics ballistics = new Ballistics();
        Move move = new Move();

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        time = Time.deltaTime + time;
        if (time > 0.1)
        {
            randomX = Random.Range(-15, 15);
            randomZ = Random.Range(-15, 15);
            Vector3 whereToSpawn = new Vector3(randomX, 30 , randomZ);
            
            GameObject Enemy = Instantiate(move.enemyPrefab, whereToSpawn, Quaternion.identity);
            Enemy.GetComponent<Rigidbody>().velocity = transform.forward * ballistics.v;
            count++;


            Destroy(Enemy, 5);
            time = 0;
        }
        return null;
    }
    
}






//using UnityEngine;

//public class Spawner : MonoBehaviour
//{
//    [SerializeField] private GameObject obj;
//    [SerializeField] private float time = 0;
//    [SerializeField] private int count = 0;
//    private float randomX;
//    public GameObject Enemy;
//    private float randomZ;

//    //Start is called before the first frame update


//    // Update is called once per frame
//    void Update()
//    {
//        time = Time.deltaTime + time;
//        if (time > 0.1)
//        {
//            randomX = Random.Range(-100, 100);
//            randomZ = Random.Range(-70, 100);
//            Vector3 whereToSpawn = new Vector3(randomX, 60, randomZ);
//            Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
//            count++;


//            Destroy(Enemy, 5);
//            time = 0;
//        }
//    }
//}

//public class Ball : MonoBehaviour
//{
//    public Transform SpawnTransform;
//    public Transform TargetTransform;

//    public float AngleInDegrees;
//    float g = Physics.gravity.y;

//    protected float v;
//    // Update is called once per frame
//    void Update()
//    {
//    }

//    public void Shoot(Spawner spawner)
//    {

//        Vector3 fromTo = TargetTransform.position - transform.position;
//        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

//        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

//        float x = fromToXZ.magnitude;
//        float y = fromTo.y;
//        float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
//        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
//        float v = Mathf.Sqrt(Mathf.Abs(v2));

//        GameObject en = GetComponent<GameObject>();
//        spawner.Enemy = en; ;
//        en.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;

//    }
//}

//public class Spawner : MonoBehaviour
//{
//    [SerializeField] Transform SpawnTransform;
//    [SerializeField] Transform TargetTransform;

//    public float AngleInDegrees;
//    float g = Physics.gravity.y;

//    [SerializeField] private GameObject obj;
//    [SerializeField] private float time = 0;
//    [SerializeField] private int count = 0;
//    private float randomX;
//    private float randomZ;

//    protected float v;

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
//            randomZ = Random.Range(70, -100);
//            Vector3 whereToSpawn = new Vector3(randomX, 60, randomZ);
//            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
//            count++;
//            Enemy.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;

//            Destroy(Enemy, 5);
//            time = 0;
//        }

//    }
//}

//======================================================================================================//

//=================================================================================================//

// Update is called once per frame
//void Update()
//{
//    if (Time.deltaTime > 0 ) 
//    {
//        timeFromSpawn = Time.deltaTime + timeFromSpawn;

//        if (timeFromSpawn >= 1) 
//        {
//            if(countOfObjects > 0) 
//            {
//                randomX = Random.Range(-100, 100);
//                randomZ = Random.Range(-70, 70);
//                whereToSpawn = new Vector3(randomX, randomZ, transform.position.y);
//                GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
//                countOfObjects -= 1;
//                Destroy(Enemy, 2);

//                timeFromSpawn = 0;
//            }

//        }


//}
//}


//---------------------------------------------------------------------------------------------------

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
//    [SerializeField] private float timeFromSpawn = 1;
//    [SerializeField] private int countOfObjects = 20;



//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Time.deltaTime > 0)
//        {
//            timeFromSpawn = Time.deltaTime + timeFromSpawn;

//            if (timeFromSpawn >= 1)
//            {
//                if (countOfObjects > 0)
//                {
//                    randomX = Random.Range(-100, 100);
//                    randomZ = Random.Range(-70, 70);
//                    whereToSpawn = new Vector3(randomX, randomZ, transform.position.y);
//                    GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
//                    countOfObjects -= 1;
//                    Destroy(Enemy, 2);

//                    timeFromSpawn = 0;
//                }

//            }


//        }
//    }
//}

//----------------------------------------------------------------------------------------------------

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Spawner : MonoBehaviour
//{
//    public GameObject obj;
//    private float randomX;
//    Vector3 whereToSpawn;
//    private float randomZ;
//    public float spawnDelay;
//    float spawnTime = 0.0f;

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Time.time > spawnTime)
//        {
//            spawnTime = Time.time + spawnDelay;
//            randomX = Random.Range(-100, 100);
//            randomZ = Random.Range(-70, 70);
//            whereToSpawn = new Vector3(randomX, randomZ, transform.position.y);
//            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
//            Destroy(Enemy, 1f);
//        }
//    }
//}
