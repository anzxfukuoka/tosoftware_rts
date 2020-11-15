using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBuildings : ScriptableObject
{
    public Dictionary<string, PlacedBuilding> buildingsTypes;

    public PlacedBuilding FindBuildingByName(string name) 
    {
        return buildingsTypes[name];
    }
}
