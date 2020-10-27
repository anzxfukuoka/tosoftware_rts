﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience
{
    public class Upgrade
    {
    }

    public int curExperience { get; private set; } = 0;
    public int curLevel { get; private set; } = 0;
    private int expToNextLevel = 0;

    public void upLevel()
    {
        curLevel++;
        expToNextLevel = CalculateNextLvlExp(curLevel);
        expToNextLevel = 0;
        OnLevelUp();
    }

    private int CalculateNextLvlExp(int level)
    {
        return (int)(Mathf.Exp(level));
    }

    public Experience()
    {
        curLevel = 0;
        expToNextLevel = CalculateNextLvlExp(curLevel);
    }

    public void AddExperience(int earnedExperience)
    {
        int currentExperience = curExperience + earnedExperience;
        if(currentExperience >= expToNextLevel)
        {
            currentExperience -= expToNextLevel;
            upLevel();
            AddExperience(currentExperience);
        }
        curExperience = currentExperience;
    }
    
    public virtual Upgrade OnLevelUp()
    {
        Debug.Log("Level up: lvl " + curLevel + " experince to nextLvl: " + expToNextLevel);
        return new Upgrade();
    }

}
