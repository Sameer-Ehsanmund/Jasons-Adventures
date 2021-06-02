using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacking : MonoBehaviour
{
    public int hitpoints = 10;    //amount of damage
    public float totarget;        //how far it is to the target
    public float range;    // the maximum distance allowed

 void Update () {
  if (Input.GetButtonDown("Attack")) {

   RaycastHit hit ;

   if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit)) {

    totarget = hit.distance;

    if (totarget < range) {

     hit.transform.SendMessage("DeductPoints", hitpoints, SendMessageOptions.DontRequireReceiver);

    }

   }

  }

 }

}
		
