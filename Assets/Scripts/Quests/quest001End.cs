using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quest001End : MonoBehaviour
{
    public int textBoxOnCheck = 0;       // Checks if TextBox is on the screen
    public GameObject messageBox;        // Defines the message box as an object
    public GameObject textBox;          // Defines the text box as an object

    public GameObject questBox;         // Defines the quest box
    public GameObject questText;        // Defines the text in the Quest box

    public GameObject khuldeesRewarded;



    void OnMouseDown()
    {
        if (textBoxOnCheck == 0)
        {
   
            textBoxOnCheck = 1;
            messageBox.SetActive(true);
            textBox.GetComponent<Text>().text = "Thankya Mate! I didn't know you had it in you.";
            questText.GetComponent<Text>().text = "Active Quest: None.";
            khuldeesRewarded.GetComponent<khuldeesCollectoin>().khuldeesCollected=100;
            
        }
        else
        {
            textBoxOnCheck = 0;
            messageBox.SetActive(false);
           // textMessage = "Villager: Get the Fuck outta here then!";
        }
    }
    void Update()
    {
        // This bit enables us to use Enter or Escape button to cycle through text boxes

        if (Input.GetButtonDown("Submit"))
        {
            if (textBoxOnCheck == 1)
            {
                messageBox.SetActive(false);
                textBoxOnCheck = 0;
               
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {
            if (textBoxOnCheck == 1)
            {
                messageBox.SetActive(false);
                textBoxOnCheck = 0;
            
            }
        }
    }
}
