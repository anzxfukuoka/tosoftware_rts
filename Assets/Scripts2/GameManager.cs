using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpaceLevelSettings spaceLevelSettings;
    //public RTSLevelSettings rtsLevelSettings;

    private SpaceLevelBuilder spaceLevelBuilder;

    // Start is called before the first frame update
    void Start()
    {
        spaceLevelBuilder = new SpaceLevelBuilder();
        spaceLevelBuilder.SetLevelSettings(spaceLevelSettings);
        Level level = spaceLevelBuilder.BuildLevel();
        level.StartLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
