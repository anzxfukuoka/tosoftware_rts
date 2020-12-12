using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTrash : PickableSpaceThing
{
    
}

public abstract class PickableSpaceThing : MonoBehaviour, IPickable
{
    public float resource = 1;

    public void PickUp()
    {
        Debug.Log("#");
        Destroy(gameObject);
    }

    public float GetResource() 
    {
        return this.resource;
    }

}

public interface IPickable 
{
    void PickUp();
}
