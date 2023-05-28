using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    private float randomX;
    Vector3 whereToSpawn;
    private float randomZ;
    public float spawnDelay;
    float spawnTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime) 
        {
            spawnTime = Time.time + spawnDelay;
            randomX = Random.Range(-100, 100);
            randomZ = Random.Range(-70, 70);
            whereToSpawn = new Vector3(randomX, randomZ, transform.position.y);
            GameObject Enemy = Instantiate(obj, whereToSpawn,Quaternion.identity);
            Destroy(Enemy, 1f);
        }
    }
}
