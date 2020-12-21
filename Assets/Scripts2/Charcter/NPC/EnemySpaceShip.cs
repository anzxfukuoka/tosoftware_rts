using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DamageReciver))]
public class EnemySpaceShip : SpaceShip 
{
    private float lastAngle = 0;

    public float shootSpeed = 1;

    private float time;

    public PlayerSpaceShip player;
    public override void Update()
    {
        base.Update();
        Vector3 dir = player.GetPos() - gameObject.transform.position;
        Move  (Vector3.up * moveSpeed);
        float da = Vector3.SignedAngle(Vector3.up, dir, Vector3.forward) - lastAngle;
        Rotate(Vector3.forward * rotateSpeed * da);
        lastAngle = Vector3.SignedAngle(Vector3.up, dir, Vector3.forward);
        
        if (time >= shootSpeed)
        {
            weapon1.Use(transform);
            time = 0;
        }
        else 
        {
            time += Time.deltaTime;
        }

    }
    public override void OnDeath()
    {
        base.OnDeath();

        Debug.Log("враг здох");
        
        Destroy(gameObject);
    }
}
