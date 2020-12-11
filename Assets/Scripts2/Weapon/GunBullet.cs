using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GunBullet : Bullet
{
    protected override void OnTimeOut() 
    {
        GameObject.Destroy(gameObject);
    }

}
