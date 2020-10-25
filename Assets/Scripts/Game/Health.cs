using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Health
{
    public int max
    {
        get
        {
            return max;
        }

        set
        {
            if (!alive)
            {
                throw new Exception("");
            }

            max = value;
        }

    }

    public int _hp {
        get; private set;
    }

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
        if (_hp + hp > max) 
        {
            _hp = max;
        }
        else
        {
            _hp += hp;
        }
    }

    public void AddDamage(int damage)
    {
        if (_hp - damage < 0)
        {
            _hp = 0;
        }
        else 
        {
            _hp -= damage;
        }
    }

    public void Restore()
    {
        _hp = max;
    }
}
