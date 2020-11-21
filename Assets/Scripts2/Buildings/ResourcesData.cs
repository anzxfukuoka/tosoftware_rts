using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/*
 * Паттерн Хранитель
 * Хранитель
 * 
 * Хранит данные ресурсов
 */

[Serializable]
public class ResourcesData
{
    public List<string> avableResourceTypes { get; private set; }
    public Dictionary<string, Resource> resourcesDict { get; private set; }

    [SerializeField]
    private List<Resource> resources = new List<Resource>();

    public void Init() 
    {
        avableResourceTypes = new List<string>();
        resourcesDict = new Dictionary<string, Resource>();

        for (int i = 0; i < resources.Count; i++)
        {
            string name = resources[i].GetName();

            avableResourceTypes.Add(name);

            resourcesDict.Add(name, resources[i]);
        }
    }

    public override bool Equals(object other)
    {
        // проверяет одинаковость по списку типов ресурсов

        return this.avableResourceTypes.SequenceEqual(((ResourcesData)other).avableResourceTypes);
    }

    public Resource GetResourceByType(string type) 
    {
        return resourcesDict[type];
    }

    // нужно, чтобы работало переопределенее Equals
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }

}
