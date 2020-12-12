using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mob
//[RequireComponent(typeof(DamageReciver))]
public abstract class Character : MonoBehaviour, IMovable
{
    public virtual void Start() 
    {
        
    }

    public virtual void Update() 
    {

    }

    public void Move(Vector3 direction)
    {
        gameObject.transform.Translate(direction);
    }

    public void Rotate(Vector3 angle)
    {
        gameObject.transform.Rotate(angle);    
    }
}

public abstract class SpaceShip : Character, IDamagaReciver 
{
    protected Health health = new Health();
    protected DamageReciver damageReciver;

    public Weapon weapon1;
    public Weapon weapon2;

    public override void Start()
    {
        base.Start();

        damageReciver = GetComponent<DamageReciver>();
        damageReciver.SetReciver(this);
    }

    public virtual void OnDamage(int damage)
    {
        health.Hit(damage);

        if (!health.alive)
        {
            OnDeath();
        }
    }

    public virtual void OnDeath()
    {
        /* -_- */
        //throw new System.NotImplementedException();
    }
}