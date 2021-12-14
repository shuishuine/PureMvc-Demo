using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagDataProxy : PureMVC.Patterns.Proxy
{
    public static new string NAME = "BagDataProxy";

    public BagDataModel BagModel;

    public BagDataProxy() : base(NAME)
    {
        BagModel = new BagDataModel();
    }

    public override void OnRegister()
    {
        BagModel.models = new BagItemModel[BagModel.BagNum];

        BagModel.models[1] = new BagItemModel() { Name = "ÑªÆ¿¢ñ", Number = Random.Range(1, 6), Blood = 100, Magic = 0, Power = 0, Index = 1, Icon = 1001 };
        BagModel.models[2] = new BagItemModel() { Name = "ÑªÆ¿¢ò", Number = Random.Range(1, 6), Blood = 200, Magic = 0, Power = 0, Index = 2, Icon = 1002 };
        BagModel.models[3] = new BagItemModel() { Name = "ÑªÆ¿¢ó", Number = Random.Range(1, 6), Blood = 300, Magic = 0, Power = 0, Index = 3, Icon = 1003 };
        BagModel.models[4] = new BagItemModel() { Name = "ÑªÆ¿¢ô", Number = Random.Range(1, 6), Blood = 400, Magic = 0, Power = 0, Index = 4, Icon = 1004 };
        BagModel.models[5] = new BagItemModel() { Name = "ÑªÆ¿¢õ", Number = Random.Range(1, 6), Blood = 500, Magic = 0, Power = 0, Index = 5, Icon = 1005 };

        BagModel.models[6] = new BagItemModel() { Name = "À¶Æ¿¢ñ", Number = Random.Range(1, 6), Blood = 0, Magic = 10, Power = 0, Index = 6, Icon = 1006 };
        BagModel.models[7] = new BagItemModel() { Name = "À¶Æ¿¢ò", Number = Random.Range(1, 6), Blood = 0, Magic = 20, Power = 0, Index = 7, Icon = 1007 };
        BagModel.models[8] = new BagItemModel() { Name = "À¶Æ¿¢ó", Number = Random.Range(1, 6), Blood = 0, Magic = 30, Power = 0, Index = 8, Icon = 1008 };
        BagModel.models[9] = new BagItemModel() { Name = "À¶Æ¿¢ô", Number = Random.Range(1, 6), Blood = 0, Magic = 40, Power = 0, Index = 9, Icon = 1009 };
        BagModel.models[10] = new BagItemModel() { Name = "À¶Æ¿¢õ", Number = Random.Range(1, 6), Blood = 0, Magic = 50, Power = 0, Index = 10, Icon = 1010 };

        BagModel.models[11] = new BagItemModel() { Name = "±¦Öé¢ñ", Number = Random.Range(1, 6), Blood = 10, Magic = 0, Power = 100, Index = 11, Icon = 1011 };
        BagModel.models[12] = new BagItemModel() { Name = "±¦Öé¢ò", Number = Random.Range(1, 6), Blood = 20, Magic = 0, Power = 200, Index = 12, Icon = 1012 };
        BagModel.models[13] = new BagItemModel() { Name = "±¦Öé¢ó", Number = Random.Range(1, 6), Blood = 30, Magic = 0, Power = 300, Index = 13, Icon = 1013 };
        BagModel.models[14] = new BagItemModel() { Name = "±¦Öé¢ô", Number = Random.Range(1, 6), Blood = 40, Magic = 0, Power = 400, Index = 14, Icon = 1014 };
        BagModel.models[15] = new BagItemModel() { Name = "±¦Öé¢õ", Number = Random.Range(1, 6), Blood = 50, Magic = 0, Power = 500, Index = 15, Icon = 1015 };
    }

    public BagItemModel Reduce(int Index)
    {
        var model = BagModel.models[Index];
        if (model != null && model.Number > 0)
        {
            model.Number--;
            if (model.Number <= 0)
            {
                BagModel.models[Index] = null;
            }
            SendNotification(MyFacade.UPDATE_BAG);
        }
        return model;
    }
}
