using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // в будущем поместить в класс плеера
    // или еще куда
    // хз
    WarehouseController playerWarehouseController; //testfield
    // и это тоже
    public ResourcesData resourcesData; //testfield

    // пока испльзуется только координата х
    // [0, 5]
    public BuildPoint buildPoint = new BuildPoint(); //testfield 
    public BuildingSettings buildingSettings; //testfield 

    public BuildField buildField;

    // Start is called before the first frame update
    void Start()
    {
        resourcesData.Init();

        playerWarehouseController = new WarehouseController(resourcesData);
        
        playerWarehouseController.AddResource(typeof(Scraps).Name);

        buildField.Init(ref playerWarehouseController);

        buildingSettings.Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            buildField.PlaceBuilding(buildingSettings, buildPoint);
        }
    }
}
