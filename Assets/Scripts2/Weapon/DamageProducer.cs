using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * обьект класса, наследуемого от этого,
 * генерит урон другому обьекту, к которому на сцене  
 * приклеплен DamageReciver, при прикосновении к нему если,
 * тег этого обьекта есть в списке
 * если список тегов пустой - ебет всех с DamageReciver.
 * на коллайдере должен стоять isTrigger = true
 */

public abstract class DamageProducer : CollisionProcesser
{
    private string producerTag;

    public string[] damageReciversTags;

    private int damagePower = 1;
    private int damageMultiplier = 1;

    public void SetDamagePower(int damage) 
    {
        damagePower = damage;
    }

    public void SetDamageMultiplier(int value) 
    {
        damageMultiplier = value;
    }

    public void SetProducerTag(string tag) 
    {
        producerTag = tag;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;

        ProcessColissions(other);
    }

    protected override void ProcessColissions(GameObject other)
    {
        if (other.tag == producerTag)
        {
            return;
        }

        if (damageReciversTags.Length > 0)
        {
            for (int i = 0; i < damageReciversTags.Length; i++)
            {
                
                if (other.tag == damageReciversTags[i])
                {
                    ProduceDamage(other);
                }
            }
        }
        else
        {
            ProduceDamage(other);
           
        }

    }

    protected void ProduceDamage(GameObject reciver) 
    {
        DamageReciver damageReciver = reciver.GetComponent<DamageReciver>();
        if (damageReciver != null)
        {
            damageReciver.ReciveDamage(damagePower * damageMultiplier);

            OnDamaged(reciver);
        }
    }

    protected virtual void OnDamaged(GameObject other)
    {
        /* обьект дамагнул кому-то */
    }

    protected virtual void Start() 
    {
        
    }

    protected virtual void Update()
    {
        
    }
}
