using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildField : MonoBehaviour
{
    const int cellsCount = 5;

    public BuildingSpawnCell[] cells = new BuildingSpawnCell[cellsCount];

    private PlacedBuildingBuilder builder;

    private WarehouseController warehouseController;
    
    private void OnValidate()
    {
        if (cells.Length != cellsCount)
        {
            Array.Resize(ref cells, cellsCount);
            Debug.LogError("Вручную не менять");
        }
    }

    private void Start()
    {
        builder = PlacedBuildingBuilder.Instance;
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

        if (cells[pos].IsCellEmpty())
        {
            cells[pos].Set(placeBuilding);
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
