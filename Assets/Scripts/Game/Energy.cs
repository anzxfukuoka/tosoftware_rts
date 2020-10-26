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

    public Energy(int maxEnergy)
    {
        max = maxEnergy;
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

    public void ExtractEnergy(int removedEnergy) {
        if (energy - removedEnergy < 0)
        {
            energy = 0;
        }
        else 
        {
            energy -= removedEnergy;
        }
    }

    public void Restore() 
    {
        energy = max;
    }

}
