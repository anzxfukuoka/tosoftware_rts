using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTrash : PickableSpaceThing
{
    
}

public abstract class PickableSpaceThing : MonoBehaviour, IPickable
{
    public int value;

    public void PickUp()
    {
        Debug.Log("#");
        Destroy(gameObject);
    }

}

public interface IPickable 
{
    void PickUp();
}
