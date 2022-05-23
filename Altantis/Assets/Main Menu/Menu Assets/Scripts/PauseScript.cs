using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject optionsScreen, pauseScreen;

    public string mainMenuScene;

    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        optionsScreen.SetActive(false);
        pauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if(!isPaused)
        {
            pauseScreen.SetActive(true);
            isPaused = true;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Time.timeScale = 0f;
        } else
        {
            pauseScreen.SetActive(false);
            isPaused = false;

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            Time.timeScale = 1f;
        }
    }

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuScene);
        Time.timeScale = 1f;
    }
}
