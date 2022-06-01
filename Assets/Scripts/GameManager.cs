using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Texture2D cursorTexture;
    public Vector2 hotSpot = Vector2.zero;

    private bool isGameOver;
    private bool isPaused;
    private bool isStageCompleted;

    // Start is called before the first frame update
    void Start()
    {
        ScoringSystem.collectedCrystals = 0;
        Time.timeScale = 1f;
        isGameOver = false;
        isPaused = false;
        isStageCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            GameOver();
        }

        if (isStageCompleted)
        {
            StageComplete();
        }
    }

    public void SetGameIsOver()
    {
        this.isGameOver = true;
    }

    public void SetStageCompleted()
    {
        this.isStageCompleted = true;
    }

    private void GameOver()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    private void StageComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
