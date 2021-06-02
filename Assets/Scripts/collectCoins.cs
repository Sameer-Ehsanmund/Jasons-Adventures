using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoins : MonoBehaviour   
{
    public GameObject accessCoinCollectionScript;


    void Update()
    {

    }
    void OnTriggerEnter()
    {
        
        AudioSource coinAudio = GetComponent<AudioSource>();
        coinAudio.Play();
        accessCoinCollectionScript.GetComponent<coinCollectionSystem>().coinsCollected += 1;

       Vector3 vectore = transform.position;         // Store all Vector3
        vectore.x = 0;                               // example assign individual fox Y axe
       vectore.y = -100;
        vectore.z = 0;
        transform.position = vectore;                 // Assign back all Vector3

        StartCoroutine(CarryOn());        
    }
  IEnumerator CarryOn()
    {
       yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
