using PureMVC.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCommand : PureMVC.Patterns.SimpleCommand
{
    public override void Execute(INotification notification)
    {
        var bagProxy =  Facade.RetrieveProxy(BagDataProxy.NAME) as BagDataProxy;
        var playerProxy =  Facade.RetrieveProxy(PlayerDataProxy.NAME) as PlayerDataProxy;

        var value = bagProxy.Reduce((int)notification.Body);
        playerProxy.IncressBlood(value);
    }
}
