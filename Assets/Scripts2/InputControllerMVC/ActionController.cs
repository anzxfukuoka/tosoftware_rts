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
    public static void Action(Vector3 targetPos, int actionSet)
    {
        ActionModule.Instance.GetMove(actionSet).DoAction();
    }


    public static void Action(BuildingSettings buildingSettings, int actionSet)
    {

    }

    public static void Action(string abilityName, int actionSet)
    {

    }





}
