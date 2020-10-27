public class PlayerTraffic : Robot

{
    float speed;
    public PlayerTraffic(float speed, float X, float Y, string name) : base(name)
    {
        this.speed = speed;
        speed.X = (-1, 1);
        speed.Y = (-1, 1);



    }

    private Vector2 movement;
    void Update(float input, float X, float Y)
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(speed.X * inputX, speed.Y * inputY);


    }

}