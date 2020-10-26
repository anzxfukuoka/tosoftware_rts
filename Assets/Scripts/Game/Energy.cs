using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy
{
    public int max { get; set; } = 100;

    public int energy
    {
        get
        {
            return energy;
        }

        private set
        {
            energy = value;
        }
    }

    public Energy(int maxEnergy = 100)
    {
        max = maxEnergy;
        energy = maxEnergy;
    }

    public void BoostEnergy(int energyBoost)
    {
        max += energyBoost;
        energy += energyBoost;
    }

    public bool DecreaseEnergy(int removedEnergy)
    {
        if (max - removedEnergy < 0)
        {
            return false;
        }
        else
        {
            max -= removedEnergy;
            return true;
        }
    }

    public void ReturnEnergy(int returnedEnergy)
    {
        if (energy + returnedEnergy < max)
        {
            energy += returnedEnergy;
        }
        else {
            energy = max;
        }
    }

    public int ExtractEnergy(int extractedEnergy) {
        if (energy - extractedEnergy < 0)
        {
            return 0;
        }
        else 
        {
            energy -= extractedEnergy;
            return extractedEnergy;
        }
    }

    public void Restore() 
    {
        energy = max;
    }

}
