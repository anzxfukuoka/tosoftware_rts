using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Point
{
    public float units; // единица длинны;

    public int x;
    public int y;

    public Point(float units = 1f) 
    {
        this.units = units;
    }

    public Vector2 ToVector2() 
    {
        return new Vector2(x * units, y * units);
    }
}
