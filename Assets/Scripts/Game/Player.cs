using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IControllable
{
    private static int _n = 0;

    public int id { get; private set; }
    public string name;
    public int score { get; private set; }

    private Robot robot;
    private Builder builder;

    public Player(string name = "player")
    {
        id = ++_n;
        this.name = name;
        robot = new Robot();

        NotificationSystem.DebugMsg("player name: " + name);
        NotificationSystem.DebugMsg("player id: " + id);
    }

    public void ProcessInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            NotificationSystem.DebugMsg("Player " + name + " input W");
            robot.Move(Direction.Up);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            NotificationSystem.DebugMsg("Player " + name + " input S");
            robot.Move(Direction.Down);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            NotificationSystem.DebugMsg("Player " + name + " input A");
            robot.Move(Direction.Left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            NotificationSystem.DebugMsg("Player " + name + " input D");
            robot.Move(Direction.Right);
        }
    }
}
