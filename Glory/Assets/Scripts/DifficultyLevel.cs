using UnityEngine;

public class DifficultyLevel : MonoBehaviour
{
    [SerializeField] protected float DelayLevel;

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
