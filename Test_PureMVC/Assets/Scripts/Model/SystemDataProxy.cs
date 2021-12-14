using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemDataProxy : PureMVC.Patterns.Proxy
{
    public static new string NAME = "SystemDataProxy";
    public SystemDataModel SystemData;

    public SystemDataProxy() : base(NAME)
    {
        SystemData = new SystemDataModel();
    }

    public void RefreshSystemTime() 
    {
        SystemData.SystemTimeNow = System.DateTime.Now;
        SendNotification(MyFacade.UPDATE_TIME);
    }
}
