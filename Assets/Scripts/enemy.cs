using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int enemyhealth = 50;


    void DeductPoints(int hitpoints)
    {

        enemyhealth -= hitpoints;
    }

    void Update()
    {

        if (enemyhealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
