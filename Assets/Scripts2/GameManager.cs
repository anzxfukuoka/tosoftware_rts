using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ActionModule.Instance);
        ActionModule.Instance.GetMove(0).DoAction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
