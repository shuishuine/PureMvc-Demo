using PureMVC.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCommand : PureMVC.Patterns.SimpleCommand
{
    public override void Execute(INotification notification)
    {
        SystemDataProxy proxy = Facade.RetrieveProxy(SystemDataProxy.NAME) as SystemDataProxy;
        if (proxy != null)
        {
            proxy.RefreshSystemTime();
        }
    }
}
