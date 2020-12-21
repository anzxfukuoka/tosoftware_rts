using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CollisionProcesser : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;

        ProcessColissions(other);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;

        ProcessColissions(other);
    }

    protected abstract void ProcessColissions(GameObject other);

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }
}
