using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Resources/ResourceComposit")]
public class ResourceComposit : ScriptableObject
{
    private List<string> avableResourceTypes;

    private Dictionary<string, Resource> res;

    [SerializeField] private List<Resource> _allResources = new List<Resource>();

    public ResourceComposit() 
    {
        for (int i = 0; i < _allResources.Count; i++) 
        {
            string name = _allResources[i].GetName();

            avableResourceTypes.Add(name);

            res.Add(name, _allResources[i]);
        }
    }

    // IsEnough
    public bool Conteins(ResourceComposit other)
    {
        if (!this.Equals(other))
        {
            throw new Exception("Uncomparable");
        }

        for (int i = 0; i < avableResourceTypes.Count; i++) 
        {
            string type = avableResourceTypes[i];

            int need = other.res[type].curAmount;

            if (!res[type].HasEnough(need)) 
            {
                return false;
            }
        }

        return true;
    }

    public bool SubstractResources(ResourceComposit other)
    {
        if (this.Conteins(other)) 
        {
            for (int i = 0; i < avableResourceTypes.Count; i++) 
            {
                string type = avableResourceTypes[i];

                int amount = other.res[type].curAmount;

                res[type].Extract(amount);
            }

            return true;
        }

        return false;
    }

    public override bool Equals(object obj)
    {
        ResourceComposit other = (ResourceComposit)obj;

        HashSet<string> o1 = new HashSet<string>(this.avableResourceTypes);
        HashSet<string> o2 = new HashSet<string>(other.avableResourceTypes);

        return o1 == o2;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
