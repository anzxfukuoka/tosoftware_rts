using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRTS : ControllableCharacter
{

    public float moveSpeed = 1;
    public float rotateSpeed = 1;

    public override void OnInputButton(InputController.InputButtonEventArgs args)
    {
        switch (args.type)
        {
            case InputButtonType.ButtonA:
                Debug.Log("ButtonA pressed");
                break;

            case InputButtonType.ButtonB:
                Debug.Log("ButtonB pressed");
                break;

            case InputButtonType.Up:
                Debug.Log("Up pressed");
                Move(Vector3.up * moveSpeed * Time.deltaTime);
                break;

            case InputButtonType.Down:
                Debug.Log("Down pressed");
                Move(Vector3.down * moveSpeed * Time.deltaTime);
                break;

            case InputButtonType.Left:
                Debug.Log("Left pressed");
                Move(Vector3.left * moveSpeed * Time.deltaTime);
                break;

            case InputButtonType.Right:
                Debug.Log("Right pressed");
                Move(Vector3.right * moveSpeed * Time.deltaTime);        
                break;
        }

    }
}
