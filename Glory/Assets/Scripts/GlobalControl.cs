using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static float DelayLevel;// �������� � ��������� � �������� ����� ��������, ������������ ����� ��������� ������ ���������  

}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GlobalControl : MonoBehaviour
//{
//    public static GlobalControl Instance;
//    public float DelayLevel;// �������� � ��������� � �������� ����� ��������, ������������ ����� ��������� ������ ���������  

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


