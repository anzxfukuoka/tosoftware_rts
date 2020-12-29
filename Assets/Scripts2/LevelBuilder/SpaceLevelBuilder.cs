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
        level.spaceTrashs = GenerateSpaceTrash(levelSettings, 1);

        return level;
    }

    private List<SpawnPreSet> GetMapEdges(SpaceLevelSettings levelSettings) 
    {
        List<SpawnPreSet> endBlocks = new List<SpawnPreSet>();

        int centerX = levelSettings.mapSize.x / 2,
            centerY = levelSettings.mapSize.y / 2;

        for (int i = 0; i < levelSettings.mapSize.x; i++)
        {
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(i - centerX, levelSettings.mapSize.y - centerY), new Vector3(), levelSettings.environmentConteiner.transform));
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(i - centerX + 1, 0 - centerY), new Vector3(), levelSettings.environmentConteiner.transform));
        }

        for (int j = 0; j < levelSettings.mapSize.y; j++)
        {
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(0 - centerX, j - centerY), new Vector3(), levelSettings.environmentConteiner.transform));
            endBlocks.Add(new SpawnPreSet(levelSettings.endBlockPrefab, new Vector3(levelSettings.mapSize.x - centerX, j - centerY + 1), new Vector3(), levelSettings.environmentConteiner.transform));
        }

        return endBlocks;
    }

    private List<SpawnPreSet> GenerateSpaceTrash(SpaceLevelSettings levelSettings, int level, int destiny = 10) 
    {
        List<SpawnPreSet> spaceTrashs = new List<SpawnPreSet>();

        // количество ресурсов на уровне зависит от уровня сложности
        
        int count = level * 10;

        switch (levelSettings.difficulty) 
        {
            case Difficulty.Easy:
                count = (int)Mathf.Sqrt(count); // прирост ресурсов при повышении уровня замедляется медленно
                break;
            case Difficulty.Normal:
                count = (int)Mathf.Log(count, 10) + 1; // прирост ресурсов при повышении уровня замедляется быстрее
                break;
            case Difficulty.Hard:
                count = (int)Mathf.Log(count, 2) + 1; // ... еще быстрее
                break;
        }

        for (int i = 0; i < count * destiny; i++)
        {
            Vector3 pos = new Vector3(
                UnityEngine.Random.Range(-levelSettings.mapSize.x / 2, levelSettings.mapSize.x / 2),
                UnityEngine.Random.Range(-levelSettings.mapSize.y / 2, levelSettings.mapSize.y / 2));

            SpawnPreSet spaceTrashSpawnPreSet = new SpawnPreSet(levelSettings.spaceTrashPrefab, pos, new Vector3(), levelSettings.levelConteiner.transform);

            spaceTrashs.Add(spaceTrashSpawnPreSet);
        }

        return spaceTrashs;
    }
}

public class SpaceLevel : Level
{
    public List<SpawnPreSet> endBlocks;
    public List<SpawnPreSet> spaceTrashs;

    public override void StartLevel()
    {
        SpawnMapEdges();
        SpawnSpaceTrash();
    }

    private void SpawnMapEdges()
    {
        for (int i = 0; i < endBlocks.Count; i++) 
        {
            EndBlock endBlock = GameObject.Instantiate(endBlocks[i].prefab, endBlocks[i].parent).GetComponent<EndBlock>();
            endBlock.SetPos((int)endBlocks[i].position.x, (int)endBlocks[i].position.y);
        } 
    }

    private void SpawnSpaceTrash() 
    {
        for (int i = 0; i < spaceTrashs.Count; i++)
        {
            SpaceTrash spaceTrash = GameObject.Instantiate(spaceTrashs[i].prefab, spaceTrashs[i].parent).GetComponent<SpaceTrash>();
            spaceTrash.SetPos(spaceTrashs[i].position.x, spaceTrashs[i].position.y);
        }
    }

}

[Serializable]
public class SpaceLevelSettings : LevelSettings
{
    public Vector2Int mapSize = new Vector2Int(10, 10);

    [Header("Prefabs")]
    
    public GameObject environmentConteiner; // статичные обьекты
    public GameObject levelConteiner; // д. обьекты
    [Space(10)]
    public GameObject endBlockPrefab;
    [Space(10)]
    public GameObject spaceTrashPrefab;
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
