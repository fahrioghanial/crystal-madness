using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
    public GameObject player;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuOptionsUI;
    public GameObject pauseMenuSoundUI;
    public GameObject pauseMenuGraphicsUI;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Texture2D cursorTexture;
    public Vector2 hotSpot = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }

    public void Resume()
    {
        //player.GetComponent<FirstPersonController>().lockCursor();
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        player.GetComponent<FirstPersonController>().unlockCursor();
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; 
    }

    private void ChangeCanvas(GameObject a, GameObject b)
    {
        a.SetActive(false);
        b.SetActive(true);
    }

    public void ChangeToOptionsUI()
    {
        ChangeCanvas(pauseMenuUI, pauseMenuOptionsUI);
    }
    
    public void ChangeToSoundOptionsUI()
    {
        ChangeCanvas(pauseMenuOptionsUI, pauseMenuSoundUI);
    }
    
    public void ChangeToGraphicsOptionsUI()
    {
        ChangeCanvas(pauseMenuOptionsUI, pauseMenuGraphicsUI);
    }

    public void ChangeBackToOptionsUISound()
    {
        ChangeCanvas(pauseMenuSoundUI, pauseMenuOptionsUI);
    }
    
    public void ChangeBackToOptionsUIGraphics()
    {
        ChangeCanvas(pauseMenuGraphicsUI, pauseMenuOptionsUI);
    }
    
    public void ChangeBackToPause()
    {
        ChangeCanvas(pauseMenuOptionsUI, pauseMenuUI);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }
}
