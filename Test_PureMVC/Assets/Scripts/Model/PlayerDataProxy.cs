using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataProxy : PureMVC.Patterns.Proxy
{
    public static new string NAME = "PlayerDataProxy";
    public PlayerDataModel Model;

    public PlayerDataProxy() : base(NAME)
    {
        Model = new PlayerDataModel();
    }

    public void IncressBlood(BagItemModel model)
    {
        Model.Blood += model.Blood;
        Model.Magic += model.Magic;
        Model.Power += model.Power;
        SendNotification(MyFacade.UPDATE_PLAYER);
    }
}
