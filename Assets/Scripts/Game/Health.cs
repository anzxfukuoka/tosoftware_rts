using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Health
{
    public int maxHP 
    {
        get 
        {
            return maxHP;
        }

        private set 
        {
            if (!alive) 
            {
                throw new Exception("");
            }

            maxHP = value;
        }
    }

    private int _hp = 100;

    public bool alive {
        get 
        {
            if (_hp <= 0)
            {
                return false;
            }

            return true;
        }
    }

    public void AddHP(int hp)
    {
        _hp += hp;
    }

    public void AddDamage(int damage)
    {
        _hp -= damage;
    }
}
