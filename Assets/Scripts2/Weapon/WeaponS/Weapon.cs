﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    public string weaponName = "DefaulWeapon";
    public int damagePower;

    public Energy energy;

    public abstract void Use(Transform transform);

    public bool unlocked = true;


}
