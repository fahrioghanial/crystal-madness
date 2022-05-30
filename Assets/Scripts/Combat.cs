using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterStats))]
public class Combat : MonoBehaviour
{

    CharacterStats myStats;

    public float atkSpeed = 1f;
    private float atkCooldown = 0f;

    private void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    void Update()
    {
        atkCooldown -= Time.deltaTime; 
    }

    public void Attack(PlayerStats targetStats)
    {
        if(atkCooldown <= 0f)
        {
            targetStats.TakeDamage(myStats.damage.getValue());
            atkCooldown = 1f / atkSpeed;
        }
        
    }
}
