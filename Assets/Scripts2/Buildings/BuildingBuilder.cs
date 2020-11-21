using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBuildingBuilder
{
    private static PlacedBuildingBuilder _instance;

    private PlacedBuildings placedBuildings;

    WarehouseController sourceWarehouseController;
    BuildingSettings buildingSettings;
    BuildPoint buildPoint;

    public static PlacedBuildingBuilder Instance
    {
        get
        {
            if (_instance == null)
                _instance = new PlacedBuildingBuilder();

            return _instance;
        }
        
    }

    public PlacedBuildingBuilder() 
    {
        //placedBuildings = Resources.FindObjectsOfTypeAll<PlacedBuildings>()?[0];
        //if (placedBuildings == null)
        //{
        //    throw new System.Exception("No PlacedBuildings in ResourceFolder");
        //}
    }

    public PlacedBuildingBuilder AddWarehouseController(ref WarehouseController sourceWarehouseController) 
    {
        this.sourceWarehouseController = sourceWarehouseController;
        return this;
    }

    public PlacedBuildingBuilder AddBuildingSettings(BuildingSettings buildingSettings) 
    {
        this.buildingSettings = buildingSettings;
        return this;
    }

    public PlacedBuildingBuilder AddBuildPoint(BuildPoint buildPoint) 
    {
        this.buildPoint = buildPoint;
        return this;
    }

    public PlacedBuilding Build() 
    {
        if (sourceWarehouseController.SubstractResources(buildingSettings.neededResources))
        {
            string name = buildingSettings.buildingName;
            PlacedBuilding placedBuilding = buildingSettings.prefab.GetComponent<PlacedBuilding>(); //placedBuildings.FindBuildingByName(name)
            placedBuilding.CreatePlacedBuildingData(buildPoint);

            return placedBuilding;
        }
        else 
        {
            throw new System.Exception("Not enought resorces");
        }
        
    }

}
