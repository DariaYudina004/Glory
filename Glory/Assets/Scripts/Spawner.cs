using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject obj;
    [SerializeField] protected float time = 0;
    [SerializeField] protected int count = 0;
    private float randomX;

    private float randomZ;
    [SerializeField] protected Transform SpawnTransform;
    [SerializeField] protected Transform TargetTransform;



    [SerializeField] private float invokeDelay = 5f;

    private void Update()
    {
        Invoke("Spawn", invokeDelay);
    }
    public void Spawn()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 50, fromTo.z);

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);
        time = Time.deltaTime + time;
        if (time > 1)
        {
            randomX = Random.Range(SpawnTransform.position.x - 15, SpawnTransform.position.x + 15);
            randomZ = Random.Range(SpawnTransform.position.z - 15, SpawnTransform.position.x + 15);
            Vector3 whereToSpawn = new Vector3(randomX, SpawnTransform.position.y, randomZ);
            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            Enemy.GetComponent<Rigidbody>().velocity = transform.forward * 50;
            count++;


            Destroy(Enemy, 10);
            time = 0;
        }
    }
}



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Ballistics : MonoBehaviour
//{
//    [SerializeField] GameObject prefab;
//    [SerializeField] float power = 100;
//    [SerializeField] protected float time = 0;

//    float randomX;
//    float randomZ;


//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    protected void Ball()
//    {
//        randomX = Random.Range(-100, 100);
//        randomZ = Random.Range(-100, 100);

//        Vector3 top = new Vector3(randomX, 50, randomZ);

//        Vector3 speed = (top - transform.position) * power;
//        transform.rotation = Quaternion.LookRotation(speed);

//        time = Time.deltaTime + time;
//        if (time > 1)
//        {

//            GameObject Enemy = Instantiate(prefab, top, Quaternion.identity);
//            Enemy.GetComponent<Rigidbody>().velocity = transform.forward * 50;



//            Destroy(Enemy, 5);
//            time = 0;
//        }
//    }
//}

