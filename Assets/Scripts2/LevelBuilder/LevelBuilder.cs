using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty 
{
    Easy,
    Normal,
    Hard
}

public abstract class LevelBuilder
{
    public abstract Level BuildLevel();
}

public abstract class Level 
{
    public abstract void Init();

    public abstract void StartLevel();
}

public class RTSLevelBuilder : LevelBuilder
{
    public override Level BuildLevel()
    {
        return new RTSLevel();
    }
}

public class RTSLevel : Level
{
    public override void Init()
    {
        throw new System.NotImplementedException();
    }

    public override void StartLevel()
    {
        throw new System.NotImplementedException();
    }
}