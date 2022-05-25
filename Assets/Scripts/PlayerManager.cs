using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

    public void KillPlayer()
    {
        FindObjectOfType<GameOverMenu>().GameOver();
        player.GetComponent<FirstPersonController>().unlockCursor();
        Time.timeScale = 1f;
    }
}
