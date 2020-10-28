using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Game game;

    // Start is called before the first frame update
    void Start()
    {
        game = new Game();
        game.GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        game.GameUpdate();
    }

    private void OnApplicationQuit()
    {
        game.GameExit();
    }
}
