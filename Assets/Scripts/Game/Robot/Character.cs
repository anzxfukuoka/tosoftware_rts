using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Experience experience;
    public Health health;
    public Energy energy;

    

    public Character(int maxHealth = 100, int maxEnergy = 100)
    {
        experience = new Experience();
        health = new Health(maxHealth);
        energy = new Energy(maxEnergy);
    }

    ~Character()
    {
        experience = null;
        health = null;
        energy = null;
    }

}

public class NPC : Character
{
    
}

public class PC : Character
{

}
