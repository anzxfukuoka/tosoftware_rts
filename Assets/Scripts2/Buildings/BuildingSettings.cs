using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSettings
{
    public string buildingName = "DefaultBuilding♥";
    public List<Resource> neededRes { get; private set; }

    public BuildingSettings() 
    {
        
    }

    public void Add(Resource res) 
    {
        neededRes.Add(res);
    }
}
