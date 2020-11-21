using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainbow : MonoBehaviour
{
    public float speed = 1f;

    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.color = Color.HSVToRGB(Mathf.Repeat(Time.time * speed, 1f), 1, 1);
    }
}

public class DolbayobException : Exception
{
    public DolbayobException(string msg = "") : base(msg) {}
}