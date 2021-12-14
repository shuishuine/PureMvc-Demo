using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagItem : MonoBehaviour
{
    public Text Number;
    public Text Name;
    public Image Head;
    public Button Point;
    public int Index;

    public void UpdateData(BagItemModel model)
    {
        Number.text = model.Number.ToString();
        Name.text = model.Name.ToString();
        Head.sprite = Resources.Load<Sprite>("UI/" + model.Icon);
        Index = model.Index;
    }
}
