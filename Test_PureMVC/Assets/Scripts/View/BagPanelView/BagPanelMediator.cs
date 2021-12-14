using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPanelMediator : PureMVC.Patterns.Mediator
{
    public static new string NAME = "BagPanelMediator";
    public BagPanelView View;
    public BagDataProxy Proxy;

    public BagPanelMediator(object viewComponent) : base(NAME, viewComponent)
    {
        View = (ViewComponent as GameObject).GetComponent<BagPanelView>();
        View.Tip.gameObject.SetActive(false);
        Proxy = Facade.RetrieveProxy(BagDataProxy.NAME) as BagDataProxy;
       

        View.Exit.onClick.AddListener(OpenOrClose);
        View.Tip.Exit.onClick.AddListener(CloseTip);
        View.Tip.Buy.onClick.AddListener(() => { SendNotification(MyFacade.BUY,View.Tip.Index); CloseTip(); });
    }

    public override IList<string> ListNotificationInterests()
    {
        return new List<string>() 
        {
            MyFacade.OPENORCLOSE_BAG ,
            MyFacade.UPDATE_BAG
        };
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case MyFacade.OPENORCLOSE_BAG:OpenOrClose();break;
            case MyFacade.UPDATE_BAG: UpdatePanel(); break;
        }
    }

    /// <summary>
    /// �������
    /// </summary>
    private void UpdatePanel()
    {
        var items = View.Content.GetComponentsInChildren<BagItem>();
        foreach (var item in items)
        {
            GameObject.Destroy(item.gameObject);
        }
        foreach (var item in Proxy.BagModel.models)
        {
            if (item != null)
            {
                var bagItem = CreateBagItem();
                bagItem.UpdateData(item);
            }
        }
    }

    /// <summary>
    /// �򿪻�ر�
    /// </summary>
    private void OpenOrClose()
    {
        var obj = (ViewComponent as GameObject);
        if (obj.activeSelf)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
            SendNotification(MyFacade.UPDATE_BAG);
        }
    }

    /// <summary>
    /// ��������
    /// </summary>
    /// <returns></returns>
    public BagItem CreateBagItem()
    {
        var obj = GameObject.Instantiate(Resources.Load<BagItem>("BagItem"), View.Content);
        obj.Point.onClick.AddListener(() => { OpenTip(obj.Index); });
        return obj;
    }

    /// <summary>
    /// ����ʾ���
    /// </summary>
    /// <param name="Index"></param>
    public void OpenTip(int Index)
    {
        var tip = View.Tip;
        tip.gameObject.SetActive(true);
        tip.UpdateData(Proxy.BagModel.models[Index]);
    }

    /// <summary>
    /// �ر���ʾ���
    /// </summary>
    public void CloseTip()
    {
        var tip = View.Tip;
        tip.gameObject.SetActive(false);
    }
}
