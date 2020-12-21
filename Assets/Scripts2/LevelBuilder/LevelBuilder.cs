using System;
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
    protected LevelSettings settings;

    public void SetLevelSettings(LevelSettings settings)
    {
        this.settings = settings;
    }

    public abstract Level BuildLevel();
}

public abstract class Level
{
    protected List<GameObject> staticObjects;

    public Level() 
    {
        staticObjects = new List<GameObject>();
    }

    public List<GameObject> GetStatics() 
    {
        return this.staticObjects;
    }

    public abstract void StartLevel();
}

[Serializable]
public abstract class LevelSettings 
{
    public Difficulty difficulty = Difficulty.Normal;
}