using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageManager : MonoBehaviour
{
    public LanguageManager Instance;
    public SaveAndLoad saveAndLoad;
    int languageChoice;
    Dictionary<string , string> dictionary;
    NewSaveSystem saveSystem;
    public delegate void OnLanguageChange(Dictionary<string,string> _dictionary);
    public event OnLanguageChange changeLanguage;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        //LanguageChange(1);

    }

    public void SetTextEvent(string language)
    {
        
    }

    public void SetDiccionary(int chosenLanguage)
    {
        List<string[]> tabla = new NewSaveSystem().ReadFromCSV();
        dictionary = CreateDict(tabla, chosenLanguage);
    }

    public void OnLanguageChangeAddListener(OnLanguageChange languageChangeAdd)
    {
        changeLanguage += languageChangeAdd;
    }

    public void OnLanguageChangeRemoveListener(OnLanguageChange languageChangeRemove)
    {
        changeLanguage -= languageChangeRemove;
    }

    public void LanguageChange(int languageChosen)
    {
        SetDiccionary(languageChosen);
        changeLanguage?.Invoke(dictionary);
    }

    public Dictionary<string, string> CreateDict(List<string[]> table, int language)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        foreach (var item in table)
        {
            string key = item[0];
            string value = item[language];
            dict.Add(key, value);
        }
        return dict;
    }

    public void Spanish()
    {
        languageChoice = 2;
        LanguageChange(languageChoice);
    }

    public void English()
    {
        languageChoice = 1;
        LanguageChange(languageChoice);
    }

    public void SaveButton()
    {
        saveAndLoad.SaveGame(languageChoice);
    }

    public void LoadButton()
    {
        saveAndLoad.LoadGame();
        LanguageChange(saveAndLoad.language);
    }
}