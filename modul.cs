using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module
{
    public GameTransform transform;
    private static List<Building> buildings;
    public Module(GameTransfrom t, Buildings[] alowableBuildings)
    {
        foreach (Buildings b in alowableBuildings)
        {
            buildings.Add(b);
        }
        transform = t;
    }

}
