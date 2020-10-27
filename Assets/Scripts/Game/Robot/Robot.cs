using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : PC, IControllable
{
    public Robot(int maxHP = 100, int maxEnergy = 100)
    {
        health = new Health(maxHP);
        energy = new Energy(maxEnergy);
        experience = new RobotExperience();
    }

    public void Action1()
    {
        throw new System.NotImplementedException();
    }

    public void Action2()
    {
        throw new System.NotImplementedException();
    }

    public void Move(Vector2 dir, float speed)
    {
        throw new System.NotImplementedException();
    }
}
