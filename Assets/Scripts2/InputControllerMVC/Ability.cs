using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Ablities/Default", fileName = "DefaultAlility")]

public class Ability : ScriptableObject
{
    [SerializeField] protected string _name = "defaultAbility";

    protected Transform _appliedTransform;

    public string Name => _name;
    public virtual void DoAction()
    {
        Debug.LogError("DoneAction");
    }

    public virtual void SetUp(Transform appliedTransform)
    {
        _appliedTransform = appliedTransform;
    }
    
}
