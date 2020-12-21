using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{
    SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.color = Color.HSVToRGB(Mathf.Repeat(Random.Range(0.0f, 1.0f), 1f), 1, 1);
    }
}
