using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerStats : CharacterStats
{
    public float health = 100;
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public float jumpSpeed = 10f;

    void Update()
    {
        FirstPersonController controller = GetComponent<FirstPersonController>();

        controller.setJumpSpeed(jumpSpeed);
        controller.setRunSpeed(runSpeed);
        controller.setWalkSpeed(walkSpeed);
    }
}
