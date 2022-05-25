using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public GameObject gameOverUI;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Texture2D cursorTexture;
    public Vector2 hotSpot = Vector2.zero;

    public void GameOver()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    public void ToMainMenu() => SceneManager.LoadScene("MainMenu");
}
