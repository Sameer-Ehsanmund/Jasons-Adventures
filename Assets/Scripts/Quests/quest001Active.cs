using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quest001Active : MonoBehaviour
{
    public int textBoxOnCheck = 0;
    public GameObject messageBox;
    public GameObject textBox;

    public GameObject questItemToClose;
    public GameObject questItemToShow;

    void OnMouseDown()
    {
        if (textBoxOnCheck == 0)
        {
            textBoxOnCheck = 1;
            messageBox.SetActive(true);
            textBox.GetComponent<Text>().text = "You found the loot.";
            StartCoroutine(CarryOn());
        }
    }

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
        messageBox.SetActive(false);
        questItemToClose.SetActive(false);
        questItemToShow.SetActive(true);
    }
}
