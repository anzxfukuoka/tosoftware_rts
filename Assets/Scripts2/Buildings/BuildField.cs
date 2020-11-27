using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildField : MonoBehaviour
{
    const int cellsCount = 5;

    public Transform[] cellsPositions = new Transform[cellsCount];

    private PlacedBuildingBuilder builder;
    private PlacedBuilding[] placed;

    private WarehouseController warehouseController;
    
    private void OnValidate()
    {
        if (cellsPositions.Length != cellsCount)
        {
            Array.Resize(ref cellsPositions, cellsCount);
            Debug.LogError("Вручную не менять");
        }
    }

    private void Start()
    {
        builder = new PlacedBuildingBuilder();
        placed = new PlacedBuilding[cellsCount];
    }

    public void SetWarehouseController(ref WarehouseController sourceWarehouseController) 
    {
        this.warehouseController = sourceWarehouseController;
    }

    public void PlaceBuilding(BuildingSettings buildingSettings, BuildPoint buildPoint) 
    {
        buildingSettings.Init();

        PlacedBuilding placeBuilding = builder
            .AddBuildingSettings(buildingSettings)
            .AddWarehouseController(ref warehouseController)
            .AddBuildPoint(buildPoint)
            .Build();

        int pos = buildPoint.x;

        if (placed[pos] == null)
        {
            placeBuilding.Instantiate(cellsPositions[pos]);
            placed[pos] = placeBuilding;

            Debug.Log(placed[pos]);
        }
        else 
        {
            throw new DolbayobException("на этом месте уже есть здание");
        }
    }
}

[Serializable]
public class BuildPoint : Point
{
    public Transform moduleParent;

}
