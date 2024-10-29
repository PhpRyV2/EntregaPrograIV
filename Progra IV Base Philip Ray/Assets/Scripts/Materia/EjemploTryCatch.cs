using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class EjemploTryCatch : MonoBehaviour
{

    [SerializeField] string fileName;

    public void Start()
    {
        //LeerArchivo();
        WriteFile();
    }

    public void LeerArchivo()
    {
        string filepath = Path.Combine(Application.streamingAssetsPath, fileName + ".txt");

        try
        {
            using (StreamReader sr = new StreamReader(filepath))
            {
                string contenido = sr.ReadToEnd();
                sr.Close();
                print(contenido);
            }
        }
        catch (FileNotFoundException ex)
        {
            print("Error. File not found " + ex.Message);
        }
        catch (Exception ex)
        {
            print("Error Reading the file " + ex.Message);
        }
    }

    public void WriteFile()
    {
        string filepath = Path.Combine(Application.streamingAssetsPath, fileName + ".txt");

        try
        {
            using (StreamWriter sr = new StreamWriter(filepath))
            {
                sr.WriteLine("Test");
                sr.Close();
            }
        }
        catch (Exception ex)
        {
            print("Error Reading the file " + ex.Message);
        }
    }

}
