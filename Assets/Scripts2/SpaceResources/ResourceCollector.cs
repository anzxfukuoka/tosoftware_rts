using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCollector : CollisionProcesser
{
    private delegate void OnCollect(int resource);
    private event OnCollect onCollectEvent;

    public void SetCollector(IResourceCollector collector) 
    {
        onCollectEvent += collector.OnCollect;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;

        ProcessColissions(other);
    }

    protected override void ProcessColissions(GameObject other)
    {
        SpaceTrash collectedTrash = other.gameObject.GetComponent<SpaceTrash>();

        if (collectedTrash != null) 
        {
            onCollectEvent?.Invoke(collectedTrash.GetResource());
            collectedTrash.PickUp();
        }
    }
}

public interface IResourceCollector 
{
    void OnCollect(int resource);
}