using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] Shop[] allButtons;
    [SerializeField] Money moneyManager;
    // Start is called before the first frame update
    void Start()
    {
        allButtons = GetComponents<Shop>();

        for (int i = 0; i < allButtons.Length; i++)
        {
            allButtons[i].SetManager(this);
        }
    }

    // Update is called once per frame
    public void UpdateInfoButton()
    {
        for (int i = 0;i < allButtons.Length;i++)
        {
            allButtons[i].UpdateInfo();
        }
        moneyManager.UpdateMoney();
    }
}
