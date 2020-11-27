using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllableCharacter : Character, IInputListener
{
    //определения этих функций следует перенести в дочерние классы

    public virtual void OnInputAxis(InputController.InputAxisEventArgs args)
    {
        Vector3 direction = new Vector2(args.x, args.y);
        Vector3 lastDirection = new Vector2(args.dx, args.dy);

        Move(direction);
        //Rotate((direction.x - direction.y) * Vector3.forward * 10);
    }

    public virtual void OnInputButton(InputController.InputButtonEventArgs args)
    {
        switch (args.type) 
        {
            case InputButtonType.ButtonA:
                Debug.Log("ButtonA pressed");
                break;

            case InputButtonType.ButtonB:
                Debug.Log("ButtonB pressed");
                break;
        }
    }
}
