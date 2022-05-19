using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public AudioSource collectSound;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        collectSound.Play();
        ScoringSystem.collectedCrystals++;
        Destroy(gameObject);
    }
}
