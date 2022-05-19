using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPickup : Interactable
{
    public Item item;
    public AudioSource collectSound;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.Instance.Add(item);
        if (wasPickedUp)
        {
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
