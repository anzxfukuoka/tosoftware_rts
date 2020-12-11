using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum ResourceTypes
//{
//    Energy,
//    Scraps
//}

//public ResourceTypes resourceType;

// нахуя везде пихать сранный ScriptableObject блять

[Serializable]
public class Resource : ScriptableObject
{
    public int maxAmount;

    private int _curAmount;

    public int curAmount
    {
        get 
        {
            return _curAmount;
        }

        set
        {
            if (value < 0)
                _curAmount = 0;

            else if (value > _curAmount)
                _curAmount = maxAmount;
            
            else
                _curAmount = value;

        }
    }

    public Resource(int max = 100)
    {
        maxAmount = max;
    }

    public bool HasEnough(int needed)
    {
        if (curAmount - needed < 0)
        {
            return false;
        }

        return true;
    }

    public void Add(int value)
    {
        curAmount += value;

    }

    public void Extract(int value)
    {
        curAmount -= value;
    }

    public string GetName() 
    {
        return this.GetType().Name;
    }
}
