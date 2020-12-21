using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//обьект края карты
[RequireComponent(typeof(BoxCollider2D))]
public class EndBlock : CollisionProcesser
{
    public GameObject decorativeCross;

    private BoxCollider2D col;

    public Vector2 GetSize() 
    {
        col = GetComponent<BoxCollider2D>();
        return col.size;
    }

    public void SetPos(int x, int y) 
    {
        Vector2 size = GetSize();
        transform.position = new Vector3(x * size.x, y * size.y, 0);
    }

    protected override void ProcessColissions(GameObject other)
    {
        Debug.Log("нечто ебнулось об край карты");

        if (other.tag.Equals("PickableSpaceThing")) 
        {
            Rigidbody2D rig = other.GetComponent<Rigidbody2D>();
            if (rig != null) 
            {
                Vector2 direction = other.transform.position - transform.position;
                rig.AddForce(direction.normalized);
            }
        }
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        decorativeCross.transform.Rotate(Vector3.forward * 1.2f);
    }
}
