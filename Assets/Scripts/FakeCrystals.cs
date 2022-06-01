using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeCrystals : Interactable
{
    public AudioSource collectSound;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Destroy(gameObject);
        player.GetComponent<PlayerStats>().Die();
    }
}

