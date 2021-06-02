using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainQuest001ExitWoods : MonoBehaviour
{
    public GameObject textBox;
    public GameObject playerText;
    public GameObject questStatus;

    void OnTriggerEnter(Collider col)
    {

        this.transform.position = new Vector3(0,-1000,0);
        textBox.SetActive(true);
        playerText.SetActive(true);
        playerText.GetComponent<Text>().text = "That looks like someking of a village there..";
        StartCoroutine(hoho());
    }
    IEnumerator hoho()
    {

        yield return new WaitForSeconds(3);
        playerText.GetComponent<Text>().text = "";
        textBox.SetActive(false);
        StartCoroutine(hoho1());
    }
    IEnumerator hoho1()
    {

        textBox.SetActive(true);
        yield return new WaitForSeconds(1);
        playerText.GetComponent<Text>().text = "I better check it out";
        StartCoroutine(hoho2());
    }
    IEnumerator hoho2()
    {

        yield return new WaitForSeconds(3);
        playerText.GetComponent<Text>().text = "";
        textBox.SetActive(false);
        playerText.SetActive(false);

        questStatus.GetComponent<Text>().text = "Active Quest: Reach the Village";

        this.gameObject.SetActive(false);
    }
}
