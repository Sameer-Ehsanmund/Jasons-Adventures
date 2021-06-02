using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainQuest001Begin : MonoBehaviour
{
    public GameObject questUpdate;
    public GameObject playerText;
    public GameObject textDisplay;

    void Start()
    {

       // Vector3 vectore = transform.position;
       // vectore.x = 0;
       // vectore.y = -100;
       // vectore.z = 0;
       // transform.position = vectore;

        //sare ooper wale code k bajaye niiche wali ek line...

        this.transform.position =new Vector3(0,-100,0);
        questUpdate.GetComponent<Text>().text = "Active Quest: Exit the Woods!";
        StartCoroutine(hoho());    
    }
    IEnumerator hoho()
    {

        yield return new WaitForSeconds(2);
        textDisplay.SetActive(true);
        playerText.GetComponent<Text>().text = "Where the hell am I?";
        StartCoroutine(hoho2());
    }
    IEnumerator hoho2()
    {

        yield return new WaitForSeconds(2);
        playerText.GetComponent<Text>().text = "I need to find a way out of these woods.";
        StartCoroutine(hoho3());
    }
    IEnumerator hoho3()
    {

        yield return new WaitForSeconds(2);
        textDisplay.SetActive(false);
        playerText.SetActive(false);
    }
}
