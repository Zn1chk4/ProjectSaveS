using UnityEngine;
using System.IO;

// Handles saving and loading JSON data
public static class SaveSystem
{
    private static string path = Application.persistentDataPath + "/save.json";

    public static void Save(SaveData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
        Debug.Log("Game Saved");
    }

    public static SaveData Load()
    {
        if (!File.Exists(path))
        {
            Debug.Log("No save file found");
            return null;
        }

        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<SaveData>(json);
    }
}