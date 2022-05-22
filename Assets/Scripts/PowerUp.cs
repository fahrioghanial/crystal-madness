using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Interactable
{
    public AudioSource collectSound;
    public GameObject pickupEffect;

    public float multiplier = 1.4f;
    public float duration = 10f;

    public override void Interact()
    {
        base.Interact();

        StartCoroutine(PickUp());
    }

    IEnumerator PickUp()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        collectSound.Play();
        
        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.walkSpeed *= multiplier;
        stats.runSpeed *= multiplier;
        stats.jumpSpeed *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        stats.walkSpeed /= multiplier;
        stats.runSpeed /= multiplier;
        stats.jumpSpeed /= multiplier;

        Destroy(gameObject);
    }
}
