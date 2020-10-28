using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : PC
{
    public void Build(Building building) {

        building.Build(energy);
    }
}
