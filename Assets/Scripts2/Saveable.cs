using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveable
{
    void Save();
    void Load(string path);
}

[Serializable]
public class Saveable : ISaveable
{
    protected string localPath;

    protected const string fileExt = ".save"; 

    public Saveable() 
    {
        SetLocalPath("/");
    }

    private string GetPath(string filename) 
    {
        return Application.dataPath + localPath + filename + fileExt;
    }

    private void SetLocalPath(string localPath) 
    {
        this.localPath = localPath;
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Load(string path)
    {
        throw new NotImplementedException();
    }
}
