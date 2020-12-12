using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DamageReciver))]
public class PlayerSpaceShip : SpaceShip, IInputListener
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;

    public override void Start()
    {
        base.Start();

        InputController.AddInputListener(this);
    }

    public void OnInputAxis(InputController.InputAxisEventArgs args)
    {
        //throw new System.NotImplementedException();
    }

    public void OnInputButton(InputController.InputButtonEventArgs args)
    {
        switch (args.type)
        {
            case InputButtonType.ButtonA:
                //Debug.Log("ButtonA pressed");
                weapon1.Use(transform);
                break;

            case InputButtonType.ButtonB:
                //Debug.Log("ButtonB pressed");
                weapon2.Use(transform);
                break;

            case InputButtonType.Up:
                //Debug.Log("Up pressed");
                Move(Vector3.up * moveSpeed * Time.deltaTime);
                break;

            case InputButtonType.Down:
                //Debug.Log("Down pressed");
                Move(Vector3.down * moveSpeed * Time.deltaTime);
                break;

            case InputButtonType.Left:
                //Debug.Log("Left pressed");
                Rotate(Vector3.forward * rotateSpeed);
                break;

            case InputButtonType.Right:
                //Debug.Log("Right pressed");
                Rotate(Vector3.back * rotateSpeed);
                break;
        }

    }

    public Vector3 GetPos()

    {
        return gameObject.transform.position;

    }

}
