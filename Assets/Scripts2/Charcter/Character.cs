using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//моб
public class Character : MonoBehaviour, IMovable
{

    public virtual void Start() 
    {
        InputController.AddInputListener((IInputListener)this);
    }

    public virtual void Move(Vector3 direction)
    {
        gameObject.transform.Translate(direction);
    }

    public void Rotate(Vector3 angle)
    {
        gameObject.transform.Rotate(angle);    
    }
}
