using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTrash : PickableSpaceThing
{
    private const float minSpeed = 0.1f;

    [Min(minSpeed)]
    public float maxSpeed = 1f;

    private float speed;
    private Vector3 flyDirection;

    public override void Start()
    {
        base.Start();
        flyDirection = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), transform.position.z);
        speed = Random.Range(minSpeed, maxSpeed);
    }

    public override void Update()
    {
        base.Update();
        transform.Translate(flyDirection * speed * Time.deltaTime);
    }

    public void SetPos(float x, float y)
    {
        transform.position = new Vector3(x , y, 0);
    }
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

    virtual public void Start() {}

    virtual public void Update() {}
}

public interface IPickable 
{
    void PickUp();
}
