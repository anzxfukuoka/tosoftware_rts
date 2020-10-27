using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private Experience _experience;
    private Health _health;
    private Energy _energy;

    public Character(int maxHealth = 100, int maxEnergy = 100)
    {
        _experience = new Experience();
        _health = new Health(maxHealth);
        _energy = new Energy(maxEnergy);
    }

    ~Character()
    {
        _experience = null;
        _health = null;
        _energy = null;
    }
}
