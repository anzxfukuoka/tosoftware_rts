using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseController
{
    Dictionary<Resource, int> _allResources;

    private bool IsEnough(Dictionary<Resource, int> neededResources) 
    {
        //...
        return false;
    }

    public bool SubstractResources(Dictionary<Resource, int> neededResources)
    {
        if (IsEnough(neededResources))
        {
            //*substract*
        }
        else 
        {
            throw new System.Exception("Not enough resources");
        }
    }

}
