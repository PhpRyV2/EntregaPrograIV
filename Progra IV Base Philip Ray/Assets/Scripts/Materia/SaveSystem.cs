using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem
{
    public const string pjSheetKey ="pjSheetKey";
    
    
    public void SavePjSheet(PJSheetStruct pjSheetStruct, int slot)
    {
        //Inicializar un nuevo pjSheet con los valores de nuestras variables
        PjSheet pjSheet = new PjSheet(pjSheetStruct);

        //Estamos convirtiendo la clase a JSON que es siempre de tipo string
        string data = JsonUtility.ToJson(pjSheet);

        //Estamos guardando el json en player prefs
        //PlayerPrefs.SetString(pjSheetKey + slot, data);

        //Estamos guardando con StreamWrite
        WriteFile(pjSheetKey + slot, data);
    }

    public PjSheet LoadPJSheet(int slot)
    {
        //Recuperando el json mediante playerPrefs
        //string data = PlayerPrefs.GetString(pjSheetKey + slot, "NULL");

        string data = ReadFile(slot);

        if (data == "NULL")
        {
            Debug.Log("Data not found");
            return null;
        }

        //Estamos convirtiendo el Json recuperado a su clase original y guardamos la info en pjSheet
        PjSheet pjSheet = JsonUtility.FromJson<PjSheet>(data);

        return pjSheet;

    }

    void WriteFile(string ID, string data)
    {
        string filepath = Path.Combine(Application.persistentDataPath, ID + ".txt");

        try
        {
            using (StreamWriter sr = new StreamWriter(filepath))
            {
                sr.WriteLine(data);
                sr.Close();
            }
        }
        catch (Exception ex)
        {
            Debug.Log("Error Reading the file " + ex.Message);
        }
    }

    string ReadFile(int ID)
    {
        string filepath = Path.Combine(Application.persistentDataPath, "pjSheetKey" + ID + ".txt");

        try
        {
            using (StreamReader sr = new StreamReader(filepath))
            {
                string data = sr.ReadToEnd();
                sr.Close();
                return data;
            }
        }
        catch (FileNotFoundException ex)
        {
            Debug.Log("Error. File not found " + ex.Message);
        }
        catch (Exception ex)
        {
            Debug.Log("Error Reading the file " + ex.Message);
        }

        return "NULL";
    }
}
