using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Паттерн Хранитель
 * Опекун
 */

public class PlacedBuilding : MonoBehaviour
{
    public PlacedBuildingData placedBuildingData;

    private GameObject prefab => this.gameObject;

    public void CreatePlacedBuildingData(BuildPoint buildPoint) 
    {
        placedBuildingData = new PlacedBuildingData();

        placedBuildingData.health = new Health();
        placedBuildingData.energy = new Energy();
        placedBuildingData.experience = new Experience();
        placedBuildingData.buildPoint = buildPoint;
    }

    public void Upgrade() 
    {
        // placedBuildingData.experience -> upgrade
    }

    public void Remove() 
    {
        // -_-
    }

    public virtual void Instantiate(Transform parent)
    {
        //Instantiate(prefab, placedBuildingData.buildPoint.ToVector2(), 
        //    Quaternion.identity, 
        //    placedBuildingData.buildPoint.moduleParent);

        Instantiate(prefab, parent);

        Debug.Log("Instantieted building at buildpoint " + placedBuildingData.buildPoint);
    }

    public virtual void OnPlace() 
    {
        throw new NotImplementedException();
    }

    public virtual void Ability() 
    {
        throw new NotImplementedException();
    }

    public void SetPrefab(GameObject prefab) 
    {
        //this.prefab = prefab;
    }
}
