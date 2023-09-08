using UnityEngine;

public class DifficultyLevel : MonoBehaviour
{
    //[SerializeField] int LvelOnLock;

    public float DelayLevel;

    public void Easy()
    {
        DelayLevel = 2;
        Debug.Log(DelayLevel);
        GlobalControl.DelayLevel = DelayLevel;
        Debug.Log(DelayLevel);
    }
    public void Normal()
    {
        DelayLevel = 1.5f;
        Debug.Log(DelayLevel);
        GlobalControl.DelayLevel = DelayLevel;
        Debug.Log(DelayLevel);
    }

    public void Hard()
    {
        DelayLevel = 1;
        Debug.Log(DelayLevel);
        GlobalControl.DelayLevel = DelayLevel;
        Debug.Log(DelayLevel);
    }
}





//    public void Normal()
//    {
//        DelayLevel = 1;
//        Debug.Log(DelayLevel);
//        GlobalControl.Instance.DelayLevel = DelayLevel;
//        Debug.Log(DelayLevel);
//    }

//    public void Hard()
//    {
//        DelayLevel = 0.5f;
//        Debug.Log(DelayLevel);
//        GlobalControl.Instance.DelayLevel = DelayLevel;
//        Debug.Log(DelayLevel);
//    }
//}

//using UnityEngine;
//using UnityEngine.UI ;

//public class DifficultyLevel : MonoBehaviour
//{
//    //[SerializeField] int LvelOnLock;
//    [SerializeField] Button[] buttons;
//    public float DelayLevel;
//    int i = 0;
//    public void Easy()
//    {
//        if (buttons[i] == buttons[0])
//        {

//        }
//        DelayLevel = 1.5f;
//        Debug.Log(DelayLevel);
//        GlobalControl.Instance.DelayLevel = DelayLevel;
//        Debug.Log(DelayLevel);
//    }

//    public void Normal()
//    {
//        DelayLevel = 1;
//        Debug.Log(DelayLevel);
//        GlobalControl.Instance.DelayLevel = DelayLevel;
//        Debug.Log(DelayLevel);
//    }

//    public void Hard()
//    {
//        DelayLevel = 0.5f;
//        Debug.Log(DelayLevel);
//        GlobalControl.Instance.DelayLevel = DelayLevel;
//        Debug.Log(DelayLevel);
//    }
//}


















//using UnityEngine;
//using UnityEngine.UI ;

//public class DifficultyLevel : MonoBehaviour
//{
//    //[SerializeField] int LvelOnLock;
//    [SerializeField] Button[] buttons;
//    public float DelayLevel;
//    int i = 0;
//    public void Easy()
//    {
//        if (buttons[i] == buttons[0])
//        {
//            DelayLevel = 1.5f;
//            Debug.Log(DelayLevel);
//            GlobalControl.Instance.DelayLevel = DelayLevel;
//            Debug.Log(DelayLevel);
//        }
//        else if (buttons[1] == buttons[1])
//        {
//            DelayLevel = 1;
//            Debug.Log(DelayLevel);
//            GlobalControl.Instance.DelayLevel = DelayLevel;
//            Debug.Log(DelayLevel);
//        }
//        else if (buttons[2] == buttons[2])
//        {
//            DelayLevel = 0.5f;
//            Debug.Log(DelayLevel);
//            GlobalControl.Instance.DelayLevel = DelayLevel;
//            Debug.Log(DelayLevel);
//        }

//    }
//}



















//public static DifficultyLevel Instance;
//public float DelayLevel;// Задержка в генерации и создании новых объектов, предстовляет соьой показатеь уровня сложности  

//private void Awake()
//{
//    if (Instance == null)
//    {
//        DontDestroyOnLoad(gameObject);
//        Instance = this;
//    }
//    else if (Instance != this)
//    {
//        Destroy(gameObject);
//    }
//}


