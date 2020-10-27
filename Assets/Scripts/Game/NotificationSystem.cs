using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationSystem : MonoBehaviour
{
    public delegate void Messege(string msg);

    public static event Messege DebugMSG;
    public static event Messege UserMSG;

    void Start()
    {
        DebugMSG += Debug.Log; //вывод в консоль юнити
        UserMSG += Debug.Log;
    }

    public static void DebugMsg(string msg) 
    {
        DebugMSG.Invoke("DEBUG: " + msg);
    }

    public static void UserMsg(string msg)
    {
        UserMSG.Invoke("GAME: " + msg);
    }
}
