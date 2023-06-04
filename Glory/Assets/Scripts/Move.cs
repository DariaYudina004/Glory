using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 10;
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private float objectSpeed = 5f;
    [SerializeField] private float spawnRadius = 100f;

    private bool canSpawn = false;
    private IEnumerator spawnCoroutine;

    private void Start()
    {
        spawnCoroutine = SpawnObjects();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canSpawn = true;
            StartCoroutine(spawnCoroutine);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canSpawn = false;
            StopCoroutine(spawnCoroutine);
        }
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            if (canSpawn)
            {
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRadius, spawnRadius), 0f, Random.Range(-spawnRadius, spawnRadius));
                GameObject obj = Instantiate(objectPrefab, spawnPos, Quaternion.identity);

                Vector3 dirToPlayer = (transform.position - obj.transform.position).normalized;
                Rigidbody objRb = obj.GetComponent<Rigidbody>();
                objRb.velocity = dirToPlayer * objectSpeed;

                yield return new WaitForSeconds(spawnInterval);
            }
            else
            {
                yield return null;
            }
        }
    }
}
