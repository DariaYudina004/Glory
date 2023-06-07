using UnityEngine;

public class Spawner : MonoBehaviour
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

    [SerializeField] private float invokeDelay = 5f;

        private void Update()
    {
        Invoke("Spawn", invokeDelay);
    }
    public void Spawn()
    {
        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

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


            Destroy(Enemy, 5);
            time = 0;
        }
    }
}

