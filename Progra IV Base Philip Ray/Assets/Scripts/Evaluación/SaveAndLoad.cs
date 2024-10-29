using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveAndLoad : MonoBehaviour
{
    [SerializeField] string filePathgameData;
    [SerializeField] public int language;


    void Start()
    {
        filePathgameData = Path.Combine(Application.persistentDataPath, "GameData.json");
    }

    public void LoadGame()
    {
        if (File.Exists(filePathgameData))
        {
            string json = File.ReadAllText(filePathgameData);
            GameData gameData = JsonUtility.FromJson<GameData>(json);

            if (gameData != null)
            {
                language = gameData.language;
            }
            Debug.Log("Load Successful");
        }
    }

    public void SaveGame(int valueLanguage)
    {
        GameData gameData = new GameData();
        gameData.language = valueLanguage;

        string data = JsonUtility.ToJson(gameData);
        File.WriteAllText(filePathgameData, data);
        Debug.Log("Save Successful");
    }
}
