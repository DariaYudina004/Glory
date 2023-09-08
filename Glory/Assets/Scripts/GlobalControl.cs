using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static float DelayLevel;// Задержка в генерации и создании новых объектов, предстовляет соьой показатеь уровня сложности  

}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GlobalControl : MonoBehaviour
//{
//    public static GlobalControl Instance;
//    public float DelayLevel;// Задержка в генерации и создании новых объектов, предстовляет соьой показатеь уровня сложности  

//    private void Awake()
//    {
//        if (Instance == null)
//        {
//            DontDestroyOnLoad(gameObject);
//            Instance = this;
//        }
//        else if (Instance != this)
//        {
//            Destroy(gameObject);
//        }
//    }
//}


