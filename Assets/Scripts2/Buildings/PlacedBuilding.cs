using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBuilding : MonoBehaviour
{
    public Health health;
    public Energy energy;
    public BuildPoint position;

    private GameObject prefab => this.gameObject; 

    public void Place() 
    {
        //prefab span at position
    }

    public void Upgrade() 
    {
        ///
    }

    public void Remove() 
    {
        //
    }

    public virtual void Instantiate()
    {
        GameObject.Instantiate(prefab, position.ToVector2(), Quaternion.identity, position.moduleParent);
        Debug.Log("Instantieted building at");
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
