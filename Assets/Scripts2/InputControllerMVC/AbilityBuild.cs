using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Ablities/Building", fileName = "BuildingAbility")]
public class AbilityBuild : Ability
{
    [SerializeField] GameObject _buiildingPrefab;
    public AbilityBuild()
    {
        _name = "Upgrade";
    }

    public override void DoAction()
    {
        base.DoAction();
        Instantiate(_buiildingPrefab, Selectable.selected.transform);
    }
}
