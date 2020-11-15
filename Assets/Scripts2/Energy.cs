using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : Resource
{

    public void BoostEnergy(int energyBoost)
    {
        maxAmount += energyBoost;
        curAmount += energyBoost;
    }

    public Energy(int max = 100) : base(max)
    {
        curAmount = max;

    }
    public void ReturnEnergy(int returnedEnergy)
    {
        if (curAmount + returnedEnergy < maxAmount)
        {
            curAmount += returnedEnergy;
        }
        else {
            curAmount = maxAmount;
        }
    }

    public void Restore() 
    {
        curAmount = maxAmount;
    }

}
