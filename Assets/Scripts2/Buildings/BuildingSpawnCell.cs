using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawnCell : MonoBehaviour
{

    private PlacedBuilding placedBuilding = null;


    public bool IsCellEmpty() 
    {
        return placedBuilding == null;
    }

    public void Set(PlacedBuilding placedBuilding) 
    {
        placedBuilding.Instantiate(GetTransform());
        this.placedBuilding = placedBuilding;
    }

    public Transform GetTransform() 
    {
        return gameObject.transform;
    }
}
