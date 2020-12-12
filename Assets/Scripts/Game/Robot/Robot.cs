using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : PC, IMoveable
{
    public Robot(int maxHP = 100, int maxEnergy = 100)
    {
        health = new Health(maxHP);
        energy = new Energy(maxEnergy);
        experience = new RobotExperience();
        experience.OnLevelUP += LevelUp;
    }

    ~Robot()
    {
        experience.OnLevelUP -= LevelUp;
    }

    private void LevelUp(Experience.Upgrade upgrade)
    {
        health.AddHP(upgrade.hpBuff);
        energy.BoostEnergy(upgrade.energyBuff);
    }

    public void Move(Direction dir)
    {
        switch (dir) 
        {
            case Direction.Up:
                NotificationSystem.DebugMsg("робот полетел вверх");
                break;
            case Direction.Down:
                NotificationSystem.DebugMsg("робот полетел вниз");
                break;
            case Direction.Left:
                NotificationSystem.DebugMsg("робот полетел влево");
                break;
            case Direction.Right:
                NotificationSystem.DebugMsg("робот полетел вправо");
                break;
        }
    }

    public void SetUp(int maxHP = 100, int maxEnergy = 100)
    {
        health = new Health(maxHP);
        energy = new Energy(maxEnergy);
        experience = new RobotExperience();
        experience.OnLevelUP += LevelUp;
    }

    void Start()
    {
        SetUp();
        Debug.Log(experience.curExperience + " " + experience.curLevel + " " + health.curHealth + " ");
        experience.AddExperience(100);
        Debug.Log(experience.curExperience + " " + experience.curLevel + " " + health.curHealth + " ");
    }
}
