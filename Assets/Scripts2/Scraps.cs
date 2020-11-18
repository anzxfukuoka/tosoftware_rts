using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Resources/Scraps")]
public class Scraps : Resource
{
    public Scraps() : base(10000)
    {
        curAmount = 0;
        //resourceType = ResourceTypes.Scraps;
    }

}
