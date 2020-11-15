using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBuilder
{
    public static BuildingBuilder instance 
    { 
        get 
        {
            if (instance == null)
                instance = new BuildingBuilder();

            return instance;
        }

        set { }
    }

    private PlacedBuildings placedBuildings;

    public BuildingBuilder() 
    {
        placedBuildings = new PlacedBuildings();
    }

    public PlacedBuilding Build(BuildingSettings buildingSettings, BuildPoint buildPoint) 
    {
        string name = buildingSettings.buildingName;
        PlacedBuilding placedBuilding = placedBuildings.FindBuildingByName(name);
        placedBuilding.position = buildPoint;

        return placedBuilding;
    }

}
