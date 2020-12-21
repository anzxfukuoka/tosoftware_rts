using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//нетошнотная камера
public class NonSpinningCamera : MonoBehaviour
{
    public float height = 10; //высота камеры
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
            target = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(((target.transform.position - Vector3.forward * height) - transform.position));
    }
}
