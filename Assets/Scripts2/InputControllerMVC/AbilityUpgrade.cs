using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Ablities/UpgradeAbility", fileName = "UpgradeAbility")]
public class AbilityUpgrade : Ability
{
    public AbilityUpgrade()
    {
        _name = "Upgrade";
    }
    public override void DoAction()
    {
        base.DoAction();
        Selectable.selected.correspondingBuilding.Upgrade();
    }
}
