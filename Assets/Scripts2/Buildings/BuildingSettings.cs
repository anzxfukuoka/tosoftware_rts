using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Buildings/BuildingSettings")]
public class BuildingSettings : ScriptableObject
{
    public string buildingName = "DefaultBuilding♥";

    public ResourcesData neededResources;

    public GameObject prefab;

    public void Init() 
    {
        neededResources.Init();
    }
}
