using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // в будущем поместить в класс плеера
    // или еще куда
    // хз
    public WarehouseController playerWarehouseController; //testfield

    // пока испльзуется только координата х
    // [0, 5] э x 
    public BuildPoint buildPoint = new BuildPoint(); //testfield 
    public BuildingSettings buildingSettings; //testfield 

    public BuildField buildField;

    // Start is called before the first frame update
    void Start()
    {
        playerWarehouseController.Init();
        
        playerWarehouseController.AddResource(typeof(Scraps).Name, 100);

        buildField.SetWarehouseController(ref playerWarehouseController);
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
