using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseController
{
    List<Resource> _allResources;

    private bool IsEnough(List<Resource> neededResources) 
    {
        for (int i = 0; i < _allResources.Count; i++) 
        {
            if (_allResources[i].HasEnough(neededResources[i].curAmount)) 
            {
                return false;
            }
        }
        return true;
    }

    public bool SubstractResources(List<Resource> neededResources)
    {
        if (IsEnough(neededResources))
        {
            for (int i = 0; i < _allResources.Count; i++) 
            {
                _allResources[i].Extract(neededResources[i].curAmount);
            }

            return true;
        }
        else 
        {
            return false;
        }
    }

}
