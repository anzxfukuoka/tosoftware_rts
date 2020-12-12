using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : WeaponShit
{
    public bool shows = false;

    public void ShowLaser() 
    {
        shows = true;
    }

    protected override void Update()
    {
        base.Update();

        transform.rotation = weaponTransform.rotation;
        transform.position = weaponTransform.position;

        if (shows)
        {
            transform.localScale = new Vector3(1, 20, 1);
        }
        else 
        {
            transform.localScale = new Vector3(1, 0, 1);
        }
    }

    protected override void OnTimeOut() 
    {
        shows = false;
    }
}
