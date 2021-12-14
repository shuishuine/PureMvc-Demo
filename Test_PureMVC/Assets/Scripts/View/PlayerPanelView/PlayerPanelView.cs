using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanelView : MonoBehaviour
{
    public Text Name;
    public Text Blood;
    public Text Magic;
    public Text Power;
    public Button Exit;

    public void UpdateData(PlayerDataModel model)
    {
        Name.text = "姓名 : " + model.Name;
        Blood.text = "血量 : " + model.Blood.ToString();
        Magic.text = "魔力 : " + model.Magic.ToString();
        Power.text = "攻击力 : " + model.Power.ToString();
    }
}
