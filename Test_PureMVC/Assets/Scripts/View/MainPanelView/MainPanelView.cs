using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanelView : MonoBehaviour
{
    public Text timeText;
    public Button refreshBTN;
    public Button bagBTN;
    public Button playerBTN;

    public void UpdateSystemTime(System.DateTime time)
    {
        timeText.text = "当前系统时间 : " + time.ToString();
    }
}
