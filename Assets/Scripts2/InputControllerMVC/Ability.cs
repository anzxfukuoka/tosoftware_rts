using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Ablities/Default", fileName = "DefaultAlility")]
public class Ability : ScriptableObject
{
    [SerializeField] private string _name = "defaultAbility";

    public string Name => _name;
    public virtual void DoAction()
    {
        Debug.LogError("DoneAction");
    }
    
}
