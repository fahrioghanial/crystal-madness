using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePickup : Interactable
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
        FindObjectOfType<PlayerStats>().setAxePickedUp(true);
        Destroy(gameObject);
    }
}
