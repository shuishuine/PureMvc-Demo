using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagTip : MonoBehaviour
{
    public Image Head;
    public Text Name;
    public Text Blood;
    public Text Magic;
    public Text Power;
    public Text Number;
    public Button Exit;
    public Button Buy;
    public int Index;

    public void UpdateData(BagItemModel model)
    {
        Head.sprite = Resources.Load<Sprite>("UI/" + model.Icon);
        Name.text = model.Name;
        Blood.text = "血量 : " + model.Blood.ToString();
        Magic.text = "魔力 : " + model.Magic.ToString();
        Power.text = "攻击力 : " + model.Power.ToString();
        Number.text = model.Number.ToString() + "个";
        Index = model.Index;
    }
}
