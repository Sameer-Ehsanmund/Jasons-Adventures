using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khuldeesCollectoin : MonoBehaviour
{
    public int khuldeesCollected;
    void OnGUI()
    {
        GUI.Label(new Rect(10, 24, 90, 40), ("Khuldees: "+ khuldeesCollected));
    }
}
