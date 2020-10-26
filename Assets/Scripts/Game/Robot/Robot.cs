using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : PC
{
    public Robot(int maxHP = 100, int maxEnergy = 100)
    {
        health = new Health(maxHP);
        energy = new Energy(maxEnergy);
        experience = new RobotExperience();
    }
}
