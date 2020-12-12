using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * А эта пуля пъяная
 */

public class SinusoidBullet : Bullet
{
    public float amplitude = 0.05f;

    protected override void Update()
    {
        base.Update();
        transform.localPosition += Vector3.right * Mathf.Sin(Time.time / moveSpeed) * amplitude;
    }

    protected override void OnTimeOut()
    {
        GameObject.Destroy(gameObject);
    }
}
