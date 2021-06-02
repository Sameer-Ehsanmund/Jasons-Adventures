using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleButtons : MonoBehaviour
{
 
    void OnGUI()
    {
        //creating buttons on the title Screen

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 30), "Play Game"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 40, 100, 30), "Quit Game"))
        {
            Application.Quit();
        }
    }
}
