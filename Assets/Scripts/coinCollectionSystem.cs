using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollectionSystem : MonoBehaviour
{
    public int coinsCollected=0;

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 90, 40), ("Coins: " + coinsCollected));
    }
}
