using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBuilding : Selectable
{
    [SerializeField] private KeyCode _upgradeButton;

    protected override void Select()
    {
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
        while (true)
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
            }
            yield return null;
        }
    }


}
