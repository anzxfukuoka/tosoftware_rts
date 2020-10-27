﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building
{
    public string buildingName { get; private set; }
    public int _requiedEnergy { get; private set; }

    public Health health;
    public Vector2Int size { get; private set; }


    public Building(int sizeX, int sizeY, int requiedEnergy, int maxHealth, string name = "building") 
    {
        health = new Health(maxHealth);
        size = new Vector2Int(sizeX, sizeY);

        _requiedEnergy = requiedEnergy;
    }


    public void Build(Energy source) {
        if (source.HasEnoughEnergy(_requiedEnergy))
        {
            source.DecreaseEnergy(_requiedEnergy);
            BuildProcces();
        }
        else 
        {
            NotificationSystem.UserMsg("недостаточно енергии для постройки " + buildingName);
        }
    }

    public virtual void BuildProcces() 
    {
        throw new NotImplementedException();
    }

}

public class StrongBuilding : Building
{
    public StrongBuilding() 
        : base(10 , 10, 128, 9000, "Strong Building")
    { 

    }

    public override void BuildProcces()
    {
        NotificationSystem.UserMsg("строится зданище");
    }
}

public class SmallBuilding : Building
{
    public SmallBuilding()
        : base(1 , 1, 10, 2, "Small Building")
    {

    }

    public override void BuildProcces()
    {
        NotificationSystem.UserMsg("строится маленькая постройка");
    }
}