using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum BuildingType 
{
    Weapon,
    Upgrade
}

public class InteractableBuilding : Selectable
{
    [SerializeField] private KeyCode _upgradeButton;
    [SerializeField] private int _maxUpgradeLvl = 6;

    [SerializeField] private int _resourcesForUpgrade = 2;

    [SerializeField] private Weapon w;
    [SerializeField] private BuildingType type;

    private int _curUpgradeLvl;
    
    protected override void Select()
    {
        if(_curUpgradeLvl > _maxUpgradeLvl)
        {
            return;
        }
        base.Select();
        StartCoroutine(CheckForInput());

        if(type == BuildingType.Weapon)
            Building.playerInstance.weapon1 = w;
    }

    public override void DeSelect()
    {
        base.DeSelect();
        StopAllCoroutines();
    }

    bool _hasBuilding = false;
    IEnumerator CheckForInput()
    {
        if (type == BuildingType.Upgrade) 
        {
            while (_curUpgradeLvl <= _maxUpgradeLvl)
            {
                if (Input.GetKeyDown(_upgradeButton))
                {
                    if (Building.playerInstance.SubstractResources(_resourcesForUpgrade))
                    {
                        ActionController.Action("Upgrade");
                        if (!_hasBuilding)
                        {
                            UpActionSet();
                        }
                        _hasBuilding = true;
                        _curUpgradeLvl++;
                    }
                    else
                    {
                        Debug.LogError("NotEnough Resources");
                    }

                }
                yield return null;
            }
            DeSelect();
        }

        yield return null;

    }


}
