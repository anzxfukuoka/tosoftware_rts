using UnityEngine;
using System.Collections;
public class PlayerTraffic : Robot

{
    private Vector2 speed;
    public PlayerTraffic(Vector2 speed, string name) : base()
    {
        this.speed = speed;



    }

    private Vector2 movement;

    void Update()
    {

        CheckInput();

    }

    void CheckInput()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(speed.x * inputX, speed.y * inputY);


    }

}