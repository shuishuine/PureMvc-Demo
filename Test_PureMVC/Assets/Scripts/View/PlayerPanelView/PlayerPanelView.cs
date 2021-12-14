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
        Name.text = "���� : " + model.Name;
        Blood.text = "Ѫ�� : " + model.Blood.ToString();
        Magic.text = "ħ�� : " + model.Magic.ToString();
        Power.text = "������ : " + model.Power.ToString();
    }
}
