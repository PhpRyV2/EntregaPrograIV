using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;
using UnityEngine;

public class NewSaveSystem
{
    public string filePath = "C:\\Users\\phili\\Progra IV Base Philip Ray\\Assets\\Translation.csv"; //put the actual filepath
    public void WriteToCSV(List<string[]> data)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var row in data)
                {
                    string line = string.Join(",", row);
                    sw.WriteLine(line);
                }
            }
            Debug.Log("Datos escritos en el CSV con éxito.");
        }
        catch (Exception e)
        {
            Debug.LogError($"Error al escribir en el archivo CSV: {e.Message}");
        }
    }

    public List<string[]> ReadFromCSV()
    {
        List<string[]> data = new List<string[]>();

        try
        {
            using(StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] row = line.Split(",");
                    data.Add(row);
                }
            }
            Debug.Log("datos leidos del archivo CSV con éxito.");
        }
        catch (Exception e)
        {
            Debug.LogError($"Error al leer el archivo CSV: {e.Message}");
        }
        return data;
    }
}
