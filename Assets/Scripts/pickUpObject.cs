using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpObject : MonoBehaviour
{
    //This code will allow you to pick up and move objects

        public Transform target;

        void Update () {   //update is not essential to put here, but makes things easier in the long run.

}

        void OnMouseDown() {

		this.transform.position = target.position;
		this.transform.parent = GameObject.Find("FPSController").transform;
		this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
		
	}

        void OnMouseUp() {

		this.transform.parent = GameObject.Find("FPSController").transform;
		this.transform.parent = null;	
	}
}
