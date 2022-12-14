using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnePlayerMainMenu : MonoBehaviour
{
    public TMP_InputField nameInput;
    public void Start()
    {
        PlayerName.gameComplete = false;
    }

    public void LevelOne()
    {
        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);  
        if (nameInput.text.Length < 3 || nameInput.text.Length > 15)
        {
            Debug.Log("Name must be between 3 and 15 characters");
        }
        else
        {
            PlayerName.finalPlayerName = nameInput.text;
            PlayerName.levelSelection = 1;
            SceneManager.LoadScene("PlayerSelection");
            TimerScript.timeRemaining = 180;
        }
        
    }

    public void LevelTwo()
    {
        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);
        if (nameInput.text.Length < 3 || nameInput.text.Length > 15)
        {
            Debug.Log("Name must be between 3 and 15 characters");
        }
        else
        {
            PlayerName.finalPlayerName = nameInput.text;
            PlayerName.levelSelection = 2;
            SceneManager.LoadScene("PlayerSelection");
            TimerScript.timeRemaining = 180;
        }
    }

    public void Store()
    {
        SceneManager.LoadScene("Store");
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("OnePlayerLeaderboard");
    }

    public void Leaderboard2()
    {
        SceneManager.LoadScene("OnePlayerLeaderboard2");
    }
}
