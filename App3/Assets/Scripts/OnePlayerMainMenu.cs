using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnePlayerMainMenu : MonoBehaviour
{
    public TMPro.TMP_InputField nameInput;

    public void LevelOne()
    {
        if (nameInput.text.Length < 3 || nameInput.text.Length > 15)
        {
            Debug.Log("Name must be between 3 and 15 characters");
        }
        else
        {
            PlayerName.finalPlayerName = nameInput.text;
            SceneManager.LoadScene("GameScene");
        }
        
    }

    public void LevelTwo()
    {
        
    }

    public void Store()
    {
        
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("OnePlayerLeaderboard");
    }
}
