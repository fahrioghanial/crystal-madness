using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private DontDestroy bgmRoot;
    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    public void ToMainMenu()
    {
        bgmRoot = GameObject.FindWithTag("BGM").GetComponent<DontDestroy>();
        bgmRoot.StopBGM();
        SceneManager.LoadScene("MainMenu");
    }
}
