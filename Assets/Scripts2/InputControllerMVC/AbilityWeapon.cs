using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityWeapon : Ability
{
    [SerializeField] Weapon _weapon;

    

    public Weapon Weapon => _weapon;

    public AbilityWeapon()
    {
        _name = "WeaponAction";
    }

    public override void DoAction()
    {
        base.DoAction();
        _weapon.Use(_appliedTransform);

    }
}
