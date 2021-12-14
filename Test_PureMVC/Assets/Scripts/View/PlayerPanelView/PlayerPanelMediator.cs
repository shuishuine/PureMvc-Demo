using PureMVC.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPanelMediator : PureMVC.Patterns.Mediator
{
    public static new string NAME = "PlayerPanelMediator";
    public PlayerPanelView View;
    public PlayerDataProxy Proxy;

    public PlayerPanelMediator( object viewComponent) : base(NAME, viewComponent)
    {
        View = (ViewComponent as GameObject).GetComponent<PlayerPanelView>();
        Proxy = Facade.RetrieveProxy(PlayerDataProxy.NAME) as PlayerDataProxy;

      
        View.Exit.onClick.AddListener(OpenOrClose);
    }

    public override IList<string> ListNotificationInterests()
    {
        return new List<string>() 
        {
            MyFacade.OPENORCLOSE_PLAYER ,
            MyFacade.UPDATE_PLAYER 
        };
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case MyFacade.OPENORCLOSE_PLAYER:   OpenOrClose(); break;  
            case MyFacade.UPDATE_PLAYER:        UpdatePanel(); break;  
        }
    }

    /// <summary>
    /// 更新界面
    /// </summary>
    public void UpdatePanel()
    {
        View.UpdateData(Proxy.Model);
    }

    /// <summary>
    /// 开启或关闭界面
    /// </summary>
    public void OpenOrClose()
    {
        var obj = ViewComponent as GameObject;
        if (obj.activeSelf)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
            SendNotification(MyFacade.UPDATE_PLAYER);
        }
    }
}
