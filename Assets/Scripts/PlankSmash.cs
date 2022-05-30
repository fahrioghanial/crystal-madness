using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankSmash : Interactable
{
    public AudioSource impactSound;
    public AudioSource destroyedSound;
    public int plankHealth = 100;

    public override void Interact()
    {
        base.Interact();

        bool isAxePickedUp = player.GetComponent<PlayerStats>().GetAxePickedUp();
        if (isAxePickedUp)
        {
            if (plankHealth > 0)
            {
                Smash();
            }
            else
            {
                Destroyed();
            }
        }
    }

    void Smash()
    {
        impactSound.Play();
        plankHealth -= 50;
    }

    void Destroyed()
    {
        destroyedSound.Play();
        Destroy(gameObject);
    }
}
