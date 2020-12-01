using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ImmutableScene : AssetModificationProcessor
{
    static string[] OnWillSaveAssets(string[] paths)
    {
        string scenePath = "Packages/com.unity.enginesupport.esgittest/Runtime/Sample.unity";
        List<string> pathsToSave = new List<string>();
        foreach (string path in paths)
        {
            Debug.Log(path);
            //if (!path.Equals(scenePath))
                pathsToSave.Add(path);
        }
        return pathsToSave.ToArray();
    }
}
