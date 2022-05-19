using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Combat : MonoBehaviour
{
    public static void Attack()
    {
        SceneManager.LoadScene("./../Scenes/GameOver");
    }
}
