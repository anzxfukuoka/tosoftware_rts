using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPoint : Point
{
    private int gridSize;
    public Transform moduleParent;

    public Vector2 ToVector2() 
    {
        return new Vector2(this.x * gridSize, this.y * gridSize);
    }
}
