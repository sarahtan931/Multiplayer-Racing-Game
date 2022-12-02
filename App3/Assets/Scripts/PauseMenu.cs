using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

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
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        carController.resetHealth();
        isPaused = false;
        //  audio.Play();
    }

    public void Home()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
       // audio.Pause();
        Time.timeScale = 0f;
        isPaused = true;
    }
}
