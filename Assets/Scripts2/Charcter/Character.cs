using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mob
//[RequireComponent(typeof(DamageReciver))]
public class Character : MonoBehaviour, IMovable, IDamagaReciver
{
    protected Health health = new Health();
    protected DamageReciver damageReciver;

    public void Start() 
    {
        InputController.AddInputListener((IInputListener)this);
        
        damageReciver = GetComponent<DamageReciver>();
        damageReciver.SetReciver(this);
    }

    public void Move(Vector3 direction)
    {
        gameObject.transform.Translate(direction);
    }

    public void Rotate(Vector3 angle)
    {
        gameObject.transform.Rotate(angle);    
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