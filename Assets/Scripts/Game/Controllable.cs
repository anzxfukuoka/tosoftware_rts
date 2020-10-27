using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllable
{
    
}

public interface IControllable
{
    void Move(Vector2 dir, float speed);
    void Action1();
    void Action2();
}
