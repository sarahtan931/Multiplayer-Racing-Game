using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    public CarController carController;

    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject player;

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
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        player.transform.position = respawnPoint.transform.position;
        player.transform.rotation = Quaternion.Euler(0f, 1f, 0f);
        carController.resetHealth();
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
