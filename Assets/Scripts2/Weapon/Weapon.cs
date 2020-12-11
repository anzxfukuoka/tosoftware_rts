using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    public string weaponName = "DefaulWeapon";
    public int damagePower;

    public Energy energy;

    public abstract void Use(Transform transform);
}

[CreateAssetMenu(menuName = "Weapon/Gun")]
public class Gun : Weapon 
{
    public GunBullet bulletPrefab;

    public override void Use(Transform transform) 
    {
        Debug.Log("Gun shoots GunBullet");

        Bullet bullet = Instantiate(bulletPrefab);
        bullet.SetDamageMultiplier(10);
        bullet.SetTransform(ref transform);
    }
}

[CreateAssetMenu(menuName = "Weapon/LaserGun")]
public class LaserGun : Weapon
{
    public Laser laserPrefab;

    private Laser laser;

    public override void Use(Transform transform)
    {
        if (laser == null)
        {
            Debug.Log("Лазер делает вжжжжж");
            
            laser = Instantiate(laserPrefab);
            laser.SetDamageMultiplier(100);
            laser.SetTransform(ref transform);
            laser.ShowLaser();
        }
        else
        {
            Debug.Log(laserPrefab);

            if (laser.shows)
            {
                /* -_- */
            }
            else
            {
                laser.ShowLaser();
            }
        }
    }
}
