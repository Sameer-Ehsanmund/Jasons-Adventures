using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleScreenRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 4f, Space.World);   //camera rotates smoothly
    }
}
