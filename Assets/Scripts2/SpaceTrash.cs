using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTrash : PickableSpaceThing
{
    
}

public abstract class PickableSpaceThing : MonoBehaviour, IPickable
{
    public int resource = 4;

    public void PickUp()
    {
        Debug.Log("Resource Picked");
        Destroy(gameObject);
    }

    public int GetResource() 
    {
        return this.resource;
    }

}

public interface IPickable 
{
    void PickUp();
}
