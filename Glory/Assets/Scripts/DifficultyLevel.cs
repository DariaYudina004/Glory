using UnityEngine;

public class DifficultyLevel : MonoBehaviour
{
     private float delayLevel;
     public float DelayLevel { get { return delayLevel; } set { delayLevel = value; } }

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

//[field: SerializeField] public float DelayLevel { get; set; }

//public void Easy()
//{
//    DelayLevel = 2;
//    Debug.Log(DelayLevel);
//    GlobalControl.DelayLevel = DelayLevel;
//    Debug.Log(DelayLevel);
//}
//public void Normal()
//{
//    DelayLevel = 1.5f;
//    Debug.Log(DelayLevel);
//    GlobalControl.DelayLevel = DelayLevel;
//    Debug.Log(DelayLevel);
//}

//public void Hard()
//{
//    DelayLevel = 1;
//    Debug.Log(DelayLevel);
//    GlobalControl.DelayLevel = DelayLevel;
//    Debug.Log(DelayLevel);
//}