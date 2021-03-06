﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[Serializable]
public class Health
{
    public int max;

    public int curHealth { get; private set; } = 100;

    public bool alive {
        get 
        {
            if (curHealth <= 0)
            {
                return false;
            }

            return true;
        }
    }

    public Health(int maxXP = 100)
    {
        max = maxXP;
        curHealth = maxXP;
    }


    public void AddHP(int hp)
    {
        max += hp;
        curHealth += hp;
    }

    public void Heal(int hp)
    {
        if (curHealth + hp > max)
        {
            curHealth = max;
        }
        else
        {
            curHealth += hp;
        }
    }

    public void Hit(int damage)
    {
        if (curHealth - damage < 0)
        {
            curHealth = 0;
        }
        else 
        {
            curHealth -= damage;
        }
    }

    public void Restore()
    {
        curHealth = max;
    }
}
