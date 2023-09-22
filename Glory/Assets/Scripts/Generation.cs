using System.Collections.Generic;
using UnityEngine;


public class Generation : DifficultyLevel
{
    [SerializeField] private List<Transform> SpawnTransform;
    [SerializeField] private Transform TargetTransform;

    [SerializeField] private float AngleInDegrees;

    float g = Physics.gravity.y; // 9.8f

    public List<GameObject> ball ;
    [SerializeField] private float time = 0;
    [SerializeField] private int count = 0;

    [SerializeField] private float invokeDelay = 3f;
    private GameObject randObject;
    private Transform randPoint;

    public ChoosenSong choosenSong;

    private void Start()
    {
        DelayLevel = GlobalControl.DelayLevel;
        Debug.Log(DelayLevel);
        GetComponent<AudioSource>().Play();

    }
    void Update()
    {
        Invoke("Spawner", invokeDelay);

    }

    public void Spawner()
    {
        randObject = ball[Random.Range(0, ball.Count - 1)];
        randPoint = SpawnTransform[Random.Range(0, SpawnTransform.Count - 1)];

        randPoint.localEulerAngles = new Vector3(-AngleInDegrees, 0f, 0f);// изменение положения пушки поссредством изменения угла в инспекторе

        Vector3 fromTo = TargetTransform.position - transform.position; // Вектор от точки спавна до цели в которую этот объект будет лететь
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z); //Проекция вектора fromTo, чтобы объект перемещался только по двум координатам, по х и по z

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up); // объект поворачивается за целью и следит за ее передвижением 

        time = Time.deltaTime + time;
        Debug.Log(DelayLevel);
        if (time > DelayLevel)
        {
            Debug.Log(DelayLevel);
            float x = fromToXZ.magnitude; // расстояние от стрелка до цели в горизонтальной плоскости. Длина вектора fromToXZ
            float y = fromTo.y; // 

            float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
            float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
            float v = Mathf.Sqrt(Mathf.Abs(v2));

            GameObject newBall = Instantiate(randObject, randPoint.position, Quaternion.identity);
            newBall.GetComponent<Rigidbody>().velocity = randPoint.forward * v /*1.15f*/;

            Destroy(newBall, 15 );
            time = 0;
            count++;
        }
    }

}
