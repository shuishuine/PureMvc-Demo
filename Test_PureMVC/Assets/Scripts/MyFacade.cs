using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFacade : PureMVC.Patterns.Facade
{
    public const string START_GAME = "start_game";
    public const string PLAY = "play";
    public const string BUY = "buy";
    public const string UPDATE_TIME = "update_time";
    public const string UPDATE_BAG = "update_bag";
    public const string UPDATE_PLAYER = "update_player";
    public const string OPENORCLOSE_BAG = "openorclose_bag";
    public const string OPENORCLOSE_PLAYER = "openorclose_player";
    
    static MyFacade()
    {
        m_instance = new MyFacade();
    }

    public static MyFacade GetInstance()
    {
        return m_instance as MyFacade;
    }

    protected override void InitializeModel()
    {
        base.InitializeModel();
        RegisterProxy(new SystemDataProxy());
        RegisterProxy(new BagDataProxy());
        RegisterProxy(new PlayerDataProxy());
    }

    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(PLAY,typeof(PlayCommand));
        RegisterCommand(START_GAME, typeof(StartGameCommand));
        RegisterCommand(BUY, typeof(BuyCommand));
    }

    protected override void InitializeView()
    {
        base.InitializeView();
    }

    protected override void InitializeFacade()
    {
        base.InitializeFacade();
    }

    public void Launch()
    {
        SendNotification(START_GAME);
    }
}
