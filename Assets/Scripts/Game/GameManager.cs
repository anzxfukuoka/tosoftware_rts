using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    NotificationSystem notifSystem;

    public GameManager() 
    {
        notifSystem = new NotificationSystem();
    }

    public void GameStart() 
    { 
        notifSystem.DebugMsg("START");
    }

    public void GameExit() 
    {
        notifSystem.DebugMsg("EXIT");
    }

    public void GameUpdate() 
    { 

    }
}
