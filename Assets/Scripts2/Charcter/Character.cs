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
    public int resourcesCount { get; private set; } = 0;

    protected Health health = new Health();
    
    protected DamageReciver damageReciver;
    [SerializeField]protected ResourceCollector resourceCollector;

    public bool SubstractResources(int num)
    {
        if(resourcesCount >= num)
        {
            resourcesCount -= num;
            return true;
        }
        return false;
    }

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
        Debug.Log("you died, lol");
    }

    public void OnCollect(int resource)
    {
        resourcesCount += resource;
        Debug.Log("Resource collected +" + resource);
        Debug.Log(gameObject.name + " resources count: " + resourcesCount);
    }
}