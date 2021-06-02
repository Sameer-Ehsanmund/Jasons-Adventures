using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaStart_00 : MonoBehaviour
{
    public GameObject blackScreen;
    public GameObject fadeScreen;

    void Start()
    {

        StartCoroutine(hoho());
        StartCoroutine(hoho2());
    }
    //animation lambi rakhni ho gi for slow-screen black effect
    IEnumerator hoho()
    {

        yield return new WaitForSeconds(1);
        fadeScreen.GetComponent<Animator>().enabled = true;
        blackScreen.SetActive(false);
        
    }
    IEnumerator hoho2()
    {

        yield return new WaitForSeconds(0.99f);
        fadeScreen.GetComponent<Animator>().enabled = false;
        fadeScreen.SetActive(false);
    }
}
