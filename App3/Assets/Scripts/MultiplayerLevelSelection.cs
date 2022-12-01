using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerLevelSelection : MonoBehaviour
{
    public void LevelOne()
    {
        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);
        PlayerName.levelSelection = 1;
        SceneManager.LoadScene("PlayerSelectionOne");

    }

    public void LevelTwo()
    {
        PlayerName.levelSelection = 2;
        SceneManager.LoadScene("PlayerSelectionOne");
    }
}
