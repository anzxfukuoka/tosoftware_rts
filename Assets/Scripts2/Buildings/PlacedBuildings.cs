using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[CreateAssetMenu(menuName = "Buildings/PlacedBuildings")]
public class PlacedBuildings : ScriptableObject
{
    [System.Serializable]
    public class PlacedBuildingPair : SerializableDictinary<string, PlacedBuilding>.DictinaryPage
    {
        
    }

    [System.Serializable]

    public class Dictinary
    {
        [SerializeField] public List<PlacedBuildingPair> _dictinary = new List<PlacedBuildingPair>();
        public PlacedBuilding this[string key]
        {
            get => this._dictinary.Find((x) => x.Key == key).Value;
        }
    }


    [SerializeField] public Dictinary buildingsTypes;

    public PlacedBuilding FindBuildingByName(string name) 
    {
        return buildingsTypes[name];
    }
}
