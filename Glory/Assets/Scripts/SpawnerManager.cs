using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] protected Transform[] SpawnTransform;
    [SerializeField] protected GameObject[] ball;

    //[SerializeField] private float time = 0;
    //[SerializeField] private int count = 0;


    private GameObject randObject;
    private Transform randPoint;
    public GameObject RandObject { get; set; }
    public Transform RandPoint { get; set; }



    public SpawnerManager()
    {
        randObject = ball[Random.Range(0, ball.Length-1)];
        randPoint = SpawnTransform[Random.Range(0, SpawnTransform.Length-1)];


    }


}
    //protected GameObject RandObject { get { return randObject; } set { randObject = value; } }
    //protected Transform RandPoint { get { return randPoint; } set { randPoint = value; } }


    ////void Update()
    //{
    //    Spawn();
    //}

    //protected void Spawn()
    //{
    //    randObject = Random.Range(0, ball.Length);
    //    randPoint = Random.Range(0, SpawnTransform.Length);
    //    count++;


    //}


