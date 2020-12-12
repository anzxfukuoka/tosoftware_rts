using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int level = 1;
    public void Upgrade()
    {
        level++;
    }
}
