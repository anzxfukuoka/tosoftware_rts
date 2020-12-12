using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionController : MonoBehaviour
{
    [SerializeField]
    public enum ActionTypes
    {
        MoveAction,

        BuildAction_01,
        BuildAction_02,

        AbilityAction_01,
        AbilityAction_02
    }
    private static int _abilitySetIndex;

    public static void SetUpInteractable(int ablitySetIndex)
    {
        _abilitySetIndex = ablitySetIndex;
        //setUp UI for ActionSet
    }

    public static void Action(Vector3 targetPos)
    {
        ActionModule.Instance.GetMove(_abilitySetIndex).DoAction();
    }


    public static void Action(BuildingSettings buildingSettings)
    {

    }

    public static void Action(string abilityName)
    {
        (ActionModule.Instance.GetAbility(abilityName, _abilitySetIndex)).DoAction();

    }





}
