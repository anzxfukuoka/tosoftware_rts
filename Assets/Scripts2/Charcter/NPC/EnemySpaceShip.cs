using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DamageReciver))]
public class EnemySpaceShip : SpaceShip
{
    public override void OnDeath()
    {
        base.OnDeath();

        Debug.Log("враг здох");
        
        Destroy(gameObject);
    }
}
