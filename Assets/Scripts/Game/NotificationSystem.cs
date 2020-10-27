using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationSystem
{
    public delegate void Messege(string msg);

    public void DebugMsg(string msg) 
    {
        //вывод в консоль юнити
        Debug.Log("DEBUG: " + msg); 
    }

    public void UserMsg(string msg)
    {
        Debug.Log("GAME: " + msg);
    }
}
