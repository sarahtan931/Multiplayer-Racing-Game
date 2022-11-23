using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
  //  public new AudioSource audio;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
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
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        //  audio.Play();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        //TODO: Load scene on restart
        SceneManager.LoadScene(0);
        isPaused = false;
      //  audio.Play();
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
       // audio.Pause();
        Time.timeScale = 0f;
        isPaused = true;
    }
}
