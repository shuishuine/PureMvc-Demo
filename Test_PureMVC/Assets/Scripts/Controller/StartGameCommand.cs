using PureMVC.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameCommand : PureMVC.Patterns.SimpleCommand
{
    public override void Execute(INotification notification)
    {
        var obj = GameObject.Instantiate(Resources.Load<GameObject>("MainPanel")) ;
        Facade.RegisterMediator(new MainPanelMediator(obj));

        var obj2 = GameObject.Instantiate(Resources.Load<GameObject>("BagPanel"));
        Facade.RegisterMediator(new BagPanelMediator(obj2));

        var obj3 = GameObject.Instantiate(Resources.Load<GameObject>("PlayerPanel"));
        Facade.RegisterMediator(new PlayerPanelMediator(obj3));

        obj2.SetActive(false);
        obj3.SetActive(false);
    }
}
