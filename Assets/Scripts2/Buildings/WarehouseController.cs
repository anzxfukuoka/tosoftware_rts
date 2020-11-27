using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  Паттерн Хранитель
 *  класс Опекун
 *  
 *  класс контроля ресурсов
 */

[Serializable]
public class WarehouseController
{
    [SerializeField]
    private ResourcesData resourcesData;

    //public WarehouseController()
    //{
    //    this.resourcesData.Init();
    //}

    //public WarehouseController(ResourcesData resourcesData) 
    //{
    //    this.resourcesData = resourcesData;
    //    this.resourcesData.Init();
    //}

    public void Init() 
    {
        this.resourcesData.Init();
    }

    // IsEnough
    public bool Conteins(ResourcesData other)
    {
        if (!resourcesData.Equals(other))
        {
            throw new Exception("Uncomparable resources data");
        }

        List<string> avableResourceTypes = resourcesData.avableResourceTypes;

        for (int i = 0; i < avableResourceTypes.Count; i++) 
        {
            string type = avableResourceTypes[i];

            int needAmount = other.resourcesDict[type].curAmount;

            Resource res = resourcesData.GetResourceByType(type);

            if (!res.HasEnough(needAmount)) 
            {
                return false;
            }
        }

        return true;
    }

    public bool SubstractResources(ResourcesData other)
    {
        List<string> avableResourceTypes = resourcesData.avableResourceTypes;

        if (this.Conteins(other)) 
        {
            for (int i = 0; i < avableResourceTypes.Count; i++) 
            {
                string type = avableResourceTypes[i];

                int amount = other.resourcesDict[type].curAmount;

                Resource res = resourcesData.GetResourceByType(type);

                res.Extract(amount);
            }

            return true;
        }

        return false;
    }

    public void AddResource(string type, int value) 
    {
        resourcesData.GetResourceByType(type).Add(value);
    }

}
