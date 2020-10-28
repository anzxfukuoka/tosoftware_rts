using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Direction { 
    Up,
    Down,
    Left,
    Right
}

public interface IControllable 
{
    void ProcessInput();
}

public interface IMoveable
{
    void Move(Direction dir);
}