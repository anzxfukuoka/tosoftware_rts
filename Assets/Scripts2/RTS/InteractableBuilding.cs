using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBuilding : Selectable
{
    [SerializeField] private KeyCode _upgradeButton;
    [SerializeField] private int _maxUpgradeLvl = 6;

    private int _curUpgradeLvl;
    
    protected override void Select()
    {
        if(_curUpgradeLvl > _maxUpgradeLvl)
        {
            return;
        }
        base.Select();
        StartCoroutine(CheckForInput());
    }

    public override void DeSelect()
    {
        base.DeSelect();
        StopAllCoroutines();
    }

    bool _hasBuilding = false;
    IEnumerator CheckForInput()
    {
        while (_curUpgradeLvl <= _maxUpgradeLvl)
        {
            if (Input.GetKeyDown(_upgradeButton))
            {
                ActionController.Action("Upgrade");
                Debug.LogError("Upgrade");
                if (!_hasBuilding)
                {
                    UpActionSet();
                }
                _hasBuilding = true;
                _curUpgradeLvl++;
            }
            yield return null;
        }
        DeSelect();
    }


}
