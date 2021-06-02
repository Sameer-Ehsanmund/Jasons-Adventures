using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Saving : MonoBehaviour
{

    public string fileName = "savegame.data";
    void OnTriggerEnter(Collider col)
    {

        var ourFile = File.CreateText(fileName);
        ourFile.WriteLine("saveArea001");
        ourFile.Close();
    }
}
