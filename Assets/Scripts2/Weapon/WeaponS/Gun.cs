using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon/Gun")]
public class Gun : Weapon
{
    public Bullet bulletPrefab;

    public override void Use(Transform transform)
    {
        Debug.Log("Gun shoots GunBullet");

        Bullet bullet = Instantiate(bulletPrefab);
        bullet.SetTransform(ref transform);
        bullet.SetProducerTag(transform.gameObject.tag);
        bullet.SetDamageMultiplier(10);
    }
}