using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceLevelBuilder : LevelBuilder
{
    public override Level BuildLevel()
    {
        SpaceLevelSettings levelSettings = (SpaceLevelSettings)settings;

        SpaceLevel level = new SpaceLevel();

        level.endBlocks = GetMapEdges(levelSettings);

        return level;
    }

    private List<SpawnPreSet> GetMapEdges(SpaceLevelSettings levelSettings) 
    {
        List<SpawnPreSet> endBlocks = new List<SpawnPreSet>();

        int centerX = levelSettings.mapSize.x / 2,
            centerY = levelSettings.mapSize.y / 2;

        for (int i = 0; i < levelSettings.mapSize.x; i++)
        {
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(i - centerX, levelSettings.mapSize.y - centerY)));
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(i - centerX + 1, 0 - centerY)));
        }

        for (int j = 0; j < levelSettings.mapSize.y; j++)
        {
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(0 - centerX, j - centerY)));
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(levelSettings.mapSize.x - centerX, j - centerY + 1)));
        }

        return endBlocks;
    }
}

public class SpaceLevel : Level
{
    public List<SpawnPreSet> endBlocks;

    public override void StartLevel()
    {
        SpawnMapEdges();
    }

    private void SpawnMapEdges()
    {
        for (int i = 0; i < endBlocks.Count; i++) 
        {
            EndBlock endBlock = GameObject.Instantiate(endBlocks[i].prefab).GetComponent<EndBlock>();
            endBlock.SetPos((int)endBlocks[i].position.x, (int)endBlocks[i].position.y);
        } 
    }

}

[Serializable]
public class SpaceLevelSettings : LevelSettings 
{
    public Vector2Int mapSize = new Vector2Int(10, 10);
    public GameObject endBlockPrefab;
}

public class SpawnPreSet
{
    public GameObject prefab;
    public Vector3 position;
    public Vector3 rotation;
    public Transform parent;

    public SpawnPreSet(GameObject prefab, Vector3 pos = new Vector3(), Vector3 rot = new Vector3(), Transform parent = null) 
    {
        this.prefab = prefab;
        this.position = pos;
        this.rotation = rot;
        this.parent = parent;
    }
}
