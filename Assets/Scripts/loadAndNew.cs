using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class loadAndNew : MonoBehaviour
{
    public string fileName = "savegame.data";
    public string loadCode;
    public static string globalLoad;

    public void Start()
    {

        StreamReader ourFile = new StreamReader(fileName); //reading(streaming) the given files
        var line = ourFile.ReadLine();
        while (line != null)
        {
            loadCode = line;
            line = ourFile.ReadLine();
        }
        ourFile.Close();       
    }
    public void LoadGame()
    {

        globalLoad = loadCode;
        Application.LoadLevel(1);
    }
    public void QuitGame()
    {

        Application.Quit();
    }
    public void NewGame()
    {

        Application.LoadLevel(1);
    }
}
