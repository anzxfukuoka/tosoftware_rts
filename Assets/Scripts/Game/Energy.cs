using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy
{
    public int max { get; set; } = 100;

    public int _ep
    {
        get
        {
            return _ep;
        }

        private set {
            _ep = value;
        }
    }

    public void AddEnergy(int e)
    {
        if (_ep + e < max)
        {
            _ep += e;
        }
        else {
            _ep = max;
        }
    }

    public void ExtractEnergy(int e) {
        if (_ep - e < 0)
        {
            _ep = 0;
        }
        else 
        {
            _ep -= e;
        }
    }

    public void Restore() 
    {
        _ep = max;
    }

}
