using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Хоть и называется LaserGun, к классу Gun не имеет 
 * никакого отношения, прост название оружия такое
 */

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
            //Debug.Log(laserPrefab);

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
