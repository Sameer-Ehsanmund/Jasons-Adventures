using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public Transform warptarget;

    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "warp001")
        {
            this.transform.position = warptarget.position;
            
        }
    }
}
