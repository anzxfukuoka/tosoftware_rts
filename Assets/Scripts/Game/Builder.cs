using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder
{
    private Energy _energySource;

    public Builder(Energy energySource) {
        this._energySource = energySource;
    }

    public void Build(Building building) {

        building.Build(_energySource);
    }
}
