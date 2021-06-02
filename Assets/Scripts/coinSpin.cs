using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpin : MonoBehaviour
{
  //This code will rotate your coins

void Update () {
	
	transform.Rotate(0, 10, 0, Space.World);

}


}
