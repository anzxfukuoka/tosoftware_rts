using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReciver : MonoBehaviour
{
    private delegate void OnDamage(int damage);
    private event OnDamage onDamageEvent;

    public void SetReciver(IDamagaReciver damagaReciver) 
    {
        onDamageEvent += damagaReciver.OnDamage;
    }

    public void ReciveDamage(int damage) 
    {
        Debug.Log(gameObject.name + " recived " + damage + " damage");
        onDamageEvent?.Invoke(damage);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public interface IDamagaReciver
{
    void OnDamage(int damage);
    void OnDeath();
}
