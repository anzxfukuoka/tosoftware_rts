using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mob
//[RequireComponent(typeof(DamageReciver))]
public abstract class Character : MonoBehaviour, IMovable
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;

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
        //gameObject.transform.Rotate(angle);
        gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.eulerAngles + angle);
    }
}

public abstract class SpaceShip : Character, IDamagaReciver, IResourceCollector
{
    protected Health health = new Health();
    
    protected DamageReciver damageReciver;
    protected ResourceCollector resourceCollector;

    public Weapon weapon1;
    public Weapon weapon2;

    public override void Start()
    {
        base.Start();

        damageReciver = GetComponent<DamageReciver>();
        damageReciver.SetReciver(this);

        resourceCollector = GetComponent<ResourceCollector>();
        resourceCollector.SetCollector(this);
    }
    public override void Update()
    {
        base.Update();
    }

    public  virtual void OnDamage(int damage)
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

    public void OnCollect(float resource)
    {
        Debug.Log("Resource collected +" + resource);
    }
}