using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackAnimation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Attack"))
        {
            GetComponent<Animation>().Play("weaponAnimation");
        }
    }


}
