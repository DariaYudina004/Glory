//using UnityEditor.SceneManagement;
//using UnityEngine;

//public class TestGeneration : SpawnerManager
//{
//    [SerializeField] private Transform TargetTransform;
//    [SerializeField] private float AngleInDegrees;

//    float g = Physics.gravity.y; // 9.8f

//    [SerializeField] private float time = 0;
//    [SerializeField] private int count = 0;

//    [SerializeField] private float invokeDelay = 5f;

//    // Update is called once per frame
//    void Update()
//    {
//        Invoke("Spawner", invokeDelay);
//    }
//    //public TestGeneration(GameObject randObject1, Transform randPoint1)
//    //{
//    //    randObject = randObject1;
//    //    randPoint = randPoint1;
//    //}
//    public void Spawner()
//    {

//        SpawnerManager SM = new SpawnerManager();
//        SM.RandPoint.localEulerAngles = new Vector3(-AngleInDegrees, 0f, 0f);// изменение положения пушки поссредством изменения угла в инспекторе

//        Vector3 fromTo = TargetTransform.position - transform.position; // Вектор от точки спавна до цели в которую этот объект будет лететь
//        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z); //Проекция вектора fromTo, чтобы объект перемещался только по двум координатам, по х и по z

//        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up); // объект поворачивается за целью и следит за ее передвижением 

//        time = Time.deltaTime + time;
//        if (time > 1)
//        {
//            float x = fromToXZ.magnitude; // расстояние от стрелка до цели в горизонтальной плоскости. Длина вектора fromToXZ
//            float y = fromTo.y; // 

//            float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
//            float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
//            float v = Mathf.Sqrt(Mathf.Abs(v2));

//            GameObject newBall = Instantiate(SM.RandObject, SM.RandPoint.position, Quaternion.identity);
//            newBall.GetComponent<Rigidbody>().velocity = SM.RandPoint.forward * v/*1.15f*/;

//            Destroy(newBall, 5);
//            time = 0;
//            count++;
//        }

//    }


//}

//====================================================================================================================
using UnityEngine;

public class TestGeneration : DifficultyLevel
{
    [SerializeField] private Transform[] SpawnTransform;
    [SerializeField] private Transform TargetTransform;

    [SerializeField] private float AngleInDegrees;

    float g = Physics.gravity.y; // 9.8f

    [SerializeField] private GameObject[] ball;
    [SerializeField] private float time = 0;
    [SerializeField] private int count = 0;

    [SerializeField] private float invokeDelay = 3f;
    private GameObject randObject;
    private Transform randPoint;

    // Update is called once per frame
    private void Start()
    {
        DelayLevel = GlobalControl.DelayLevel;
        Debug.Log(DelayLevel);
    }
    void Update()
    {
        Invoke("Spawner", invokeDelay);

    }

    public void Spawner()
    {
        randObject = ball[Random.Range(0, ball.Length - 1)];
        randPoint = SpawnTransform[Random.Range(0, SpawnTransform.Length - 1)];

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




//======================================================================================================================
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TestGeneration : MonoBehaviour
//{
//    [SerializeField] private Transform SpawnTransform;
//    [SerializeField] private Transform TargetTransform;

//    [SerializeField] private float AngleInDegrees;

//    float g = Physics.gravity.y; // 9.8f

//    [SerializeField] private GameObject ball;
//    [SerializeField] private float time = 0;
//    [SerializeField] private int count = 0;

//    // Update is called once per frame
//    void Update()
//    {
//        SpawnTransform.localEulerAngles = new Vector3(-AngleInDegrees, 0f, 0f);// изменение положения пушки поссредством изменения угла в инспекторе
//        Spawner();
//    }

//    public void Spawner()
//    {
//        Vector3 fromTo = TargetTransform.position - transform.position; // Вектор от точки спавна до цели в которую этот объект будет лететь
//        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z); //Проекция вектора fromTo, чтобы объект перемещался только по двум координатам, по х и по z

//        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up); // объект поворачивается за целью и следит за ее передвижением 

//        time = Time.deltaTime + time;
//        if (time > 1)
//        {
//            float x = fromToXZ.magnitude; // расстояние от стрелка до цели в горизонтальной плоскости. Длина вектора fromToXZ
//            float y = fromTo.y; // 

//            float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
//            float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
//            float v = Mathf.Sqrt(Mathf.Abs(v2));

//            GameObject newBall = Instantiate(ball, SpawnTransform.position, Quaternion.identity);
//            newBall.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v * 1.15f;

//            Destroy(newBall, 5);
//            time = 0;
//            count++;
//        }

//    }


//}


//////////////////////////////////////////////////////////////////////////////////////////////////
///РАботающий код
/// using UnityEngine;

//public class TestGeneration : MonoBehaviour
//{
//    [SerializeField] private Transform[] SpawnTransform;
//    [SerializeField] private Transform TargetTransform;

//    [SerializeField] private float AngleInDegrees;

//    float g = Physics.gravity.y; // 9.8f

//    [SerializeField] private GameObject[] ball;
//    [SerializeField] private float time = 0;
//    [SerializeField] private int count = 0;

//    [SerializeField] private float invokeDelay = 5f;

//    // Update is called once per frame
//    void Update()
//    {
//        Invoke("Spawner", invokeDelay);
//    }

//    public void Spawner()
//    {
//        int randObject = Random.Range(0, ball.Length);
//        int randPoint = Random.Range(0, SpawnTransform.Length);

//        SpawnTransform[randPoint].localEulerAngles = new Vector3(-AngleInDegrees, 0f, 0f);// изменение положения пушки поссредством изменения угла в инспекторе

//        Vector3 fromTo = TargetTransform.position - transform.position; // Вектор от точки спавна до цели в которую этот объект будет лететь
//        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z); //Проекция вектора fromTo, чтобы объект перемещался только по двум координатам, по х и по z

//        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up); // объект поворачивается за целью и следит за ее передвижением 

//        time = Time.deltaTime + time;
//        if (time > 1)
//        {
//            float x = fromToXZ.magnitude; // расстояние от стрелка до цели в горизонтальной плоскости. Длина вектора fromToXZ
//            float y = fromTo.y; // 

//            float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
//            float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
//            float v = Mathf.Sqrt(Mathf.Abs(v2));

//            GameObject newBall = Instantiate(ball[randObject], SpawnTransform[randPoint].position, Quaternion.identity);
//            newBall.GetComponent<Rigidbody>().velocity = SpawnTransform[randPoint].forward * v /*1.15f*/;

//            Destroy(newBall, 5);
//            time = 0;
//            count++;
//        }

//    }


//}