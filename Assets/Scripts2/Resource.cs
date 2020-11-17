using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceTypes
{
    Energy,
    Scraps
}


public class Resource : ScriptableObject
{

    public int maxAmount;
    public ResourceTypes resourceType;

    public static int lastResourceId = 0;

    public int curAmount
    {
        get
        {
            return curAmount;
        }

        set
        {
            curAmount = value;

            if (curAmount < 0)
                curAmount = 0;

            if (curAmount > maxAmount)
                curAmount = maxAmount;

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
