using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Обычная пуля, летит по прямой
 */

[RequireComponent(typeof(Rigidbody))]
public class GunBullet : Bullet
{
    protected override void OnTimeOut() 
    {
        GameObject.Destroy(gameObject);
    }

}
