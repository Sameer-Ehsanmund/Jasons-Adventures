using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class area_001Loader : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject startingScript;
    public GameObject villageBox;
    public float playerX = 103.72f;
    public float playerY = 60.248f;
    public float playerZ = -73.444f;
    public string loadedCode;
    public GameObject questStatus;

    public void Start()
    {

        loadedCode = loadAndNew.globalLoad;

        if (loadedCode == "saveArea001")
        {

            thePlayer.transform.position = new Vector3(playerX,playerY,playerZ);
            startingScript.SetActive(false);
            villageBox.SetActive(false);
            questStatus.GetComponent<Text>().text = "Active Quest: Reach the Village";
        }
    }
}
