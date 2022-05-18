using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCrystals : MonoBehaviour
{

    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            collectSound.Play();
            ScoringSystem.collectedCrystals++;
            Destroy(gameObject);
        }

    }
}
