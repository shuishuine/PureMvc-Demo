using PureMVC.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanelMediator : PureMVC.Patterns.Mediator
{
    public const string Name = "MainPanelMediator";

    private MainPanelView View;
    private SystemDataProxy Proxy;

    public MainPanelMediator(object viewComponent) : base(NAME, viewComponent)
    {
        View = ((GameObject)ViewComponent).GetComponent<MainPanelView>();
        Proxy = Facade.RetrieveProxy(SystemDataProxy.NAME) as SystemDataProxy;

        View.refreshBTN.onClick.AddListener(() => { SendNotification(MyFacade.PLAY); });
        View.bagBTN.onClick.AddListener(() => { SendNotification(MyFacade.OPENORCLOSE_BAG); });
        View.playerBTN.onClick.AddListener(() => { SendNotification(MyFacade.OPENORCLOSE_PLAYER); });
    }

    public override IList<string> ListNotificationInterests()
    {
        return new List<string>() { MyFacade.UPDATE_TIME };
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case MyFacade.UPDATE_TIME: View.UpdateSystemTime(Proxy.SystemData.SystemTimeNow); break;
        }
    }
}
