using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//класс снаряда
public abstract class Bullet : WeaponShit
{
    public float moveSpeed = 1f;

    protected override void Update()
    {
        base.Update();
        transform.Translate(Vector3.up * moveSpeed);
    }

    protected override void OnDamaged(GameObject other)
    {
        Destroy(gameObject);
    }
}