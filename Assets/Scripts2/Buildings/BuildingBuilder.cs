﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBuilder
{
    private static BuildingBuilder _instance;

    private PlacedBuildings placedBuildings;

    public static BuildingBuilder Instance
    {
        get
        {
            if (_instance == null)
                _instance = new BuildingBuilder();

            return _instance;
        }
        
    }

    public BuildingBuilder() 
    {
        placedBuildings = Resources.FindObjectsOfTypeAll<PlacedBuildings>()?[0];
        if(placedBuildings == null)
        {
            throw new System.Exception("No PlacedBuildings in ResourceFolder");
        }
    }

    public PlacedBuilding Build(WarehouseController warehouseController, BuildingSettings buildingSettings, BuildPoint buildPoint) 
    {
        if (warehouseController.SubstractResources(buildingSettings.neededRes))
        {
            string name = buildingSettings.buildingName;
            PlacedBuilding placedBuilding = placedBuildings.FindBuildingByName(name);
            placedBuilding.position = buildPoint;
            placedBuilding.Instantiate();

            return placedBuilding;
        }
        else 
        {
            throw new System.Exception("Not enought resorces");
        }
        
    }

}
