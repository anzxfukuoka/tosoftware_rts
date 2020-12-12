using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//штуки, которые генерит оружие
public abstract class WeaponShit : DamageProducer
{
    //время после которого вызовится метод OnTimeOut
    //считается с появления на сцене
    public float lifetime = 10f; //10 сек
    private float _time = 0;

    protected Transform weaponTransform;

    public void SetTransform(ref Transform weaponTransform)
    {
        this.weaponTransform = weaponTransform;
        transform.position = this.weaponTransform.position;
        transform.rotation = this.weaponTransform.rotation;
    }

    protected override void Update()
    {
        base.Update();

        CheckToTimeToTimeout();
    }

    protected void CheckToTimeToTimeout()
    {
        _time += Time.deltaTime;

        if (_time >= lifetime)
        {
            _time = 0;
            OnTimeOut();
        }
    }

    protected virtual void OnTimeOut()
    {
        throw new System.NotFiniteNumberException();
    }

}
