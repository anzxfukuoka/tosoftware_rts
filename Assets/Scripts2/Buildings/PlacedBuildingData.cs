using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Хранитель
 */

[Serializable]
public class PlacedBuildingData
{
    public Health health;
    public Energy energy;
    public Experience experience;

    public BuildPoint buildPoint;

}
