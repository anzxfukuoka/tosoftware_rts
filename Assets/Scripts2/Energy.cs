using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Resources/Energy")]
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
        //resourceType = ResourceTypes.Energy;

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
