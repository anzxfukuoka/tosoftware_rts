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
        public int hpBuff { get; private set; }
        public int energyBuff { get; private set; }

        public LevelUpgrades(int level)
        {
            hpBuff = (int)Mathf.Exp(level) * _DEFAULTHPBUFF;
            energyBuff = (int)Mathf.Exp(level) * _DEFAULTENERGYBUFF;
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
