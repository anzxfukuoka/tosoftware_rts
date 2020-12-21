using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSLevelBuilder : LevelBuilder
{
    public override Level BuildLevel()
    {
        return new RTSLevel();
    }
}

public class RTSLevel : Level
{

    public override void StartLevel()
    {
        throw new System.NotImplementedException();
    }
}

[Serializable]
public class RTSLevelSettings : LevelSettings 
{

}