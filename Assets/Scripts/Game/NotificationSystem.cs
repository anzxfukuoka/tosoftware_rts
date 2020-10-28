using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationSystem
{
    public delegate void Messege(string msg);

    private static event Messege DebugMessege;
    private static event Messege UserMessege;

    public static void Instantiate(Messege debugMessege, Messege userMessege)
    {
        DebugMessege += debugMessege;
        UserMessege += userMessege;
    }

    public static void DebugMsg(string msg) 
    {
        DebugMessege?.Invoke(msg);
    }

    public static void UserMsg(string msg)
    {
        UserMessege?.Invoke(msg);
    }
}
