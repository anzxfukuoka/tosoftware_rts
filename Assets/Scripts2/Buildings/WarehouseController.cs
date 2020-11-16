using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Resources/Warehouse")]
public class WarehouseController : ScriptableObject
{

    [SerializeField] private List<Resource> _allResources;

    private bool IsEnough(List<Resource> neededResources) 
    {
        bool value = true;
        neededResources.ForEach(delegate (Resource resource)
        {
            bool found = false;
            foreach(Resource res in _allResources)
            {
                if (res.resourceType == resource.resourceType)
                {
                    value = value && res.HasEnough(resource.maxAmount);
                    found = true;
                    break;
                }
            }
            value = value && found;
        });
        
        return value;
    }

    public bool SubstractResources(List<Resource> neededResources)
    {
        if (IsEnough(neededResources))
        {
            neededResources.ForEach(delegate (Resource resource)
            {
                foreach (Resource res in _allResources)
                {
                    if (res.resourceType == resource.resourceType)
                    {
                        res.Extract(resource.maxAmount);
                        break;
                    }
                }
            });

            return true;
        }
        else 
        {
            return false;
        }
    }

}
