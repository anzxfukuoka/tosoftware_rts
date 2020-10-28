using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotExperience : Experience
{
    public class LevelUpgrades : Upgrade
    {
        private const int _DEFAULTHPBUFF = 30;
        private const int _DEFAULTENERGYBUFF = 40;

        public LevelUpgrades(int level)
        {
            hpBuff = (int)Mathf.Exp(level) * _DEFAULTHPBUFF;
            energyBuff = (int)Mathf.Exp(level) * _DEFAULTENERGYBUFF;
        }

        ~LevelUpgrades()
        {

        }
    }

    public LevelUpgrades levelUpgrade { get; private set; }

    public override Upgrade OnLevelUp()
    {
        levelUpgrade = new LevelUpgrades(curLevel);
        InvokeLevelUP(levelUpgrade);
        return levelUpgrade as LevelUpgrades;
    }
}
