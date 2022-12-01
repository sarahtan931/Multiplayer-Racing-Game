using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerCarSelection : MonoBehaviour
{
    private string level;
    private int picked;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "PlayerSelectionOne")
        {
            picked = 0;
        } 
        else if(SceneManager.GetActiveScene().name == "PlayerSelectionTwo")
        {
            picked = 1;
        }

        if (PlayerName.levelSelection == 1)
        {
            level = "GameSceneMultiplayer";
        }
        else if (PlayerName.levelSelection == 2)
        {
            level = "GameSceneMultiplayer2";
        }
    }
    public void GreenSelected()
    {
        if(picked == 0)
        {
            TwoPlayer.playerOneSelection = 0;
            SceneManager.LoadScene("PlayerSelectionTwo");
        }
        else
        {
            TwoPlayer.playerTwoSelection = 0;
            SceneManager.LoadScene(level);
        }
        
        
    }

    public void SilverSelected()
    {
        if (picked == 0)
        {
            TwoPlayer.playerOneSelection = 1;
            SceneManager.LoadScene("PlayerSelectionTwo");
        }
        else
        {
            TwoPlayer.playerTwoSelection = 1;
            SceneManager.LoadScene(level);
        }
    }

    public void GoldSelected()
    {
        if (picked == 0)
        {
            TwoPlayer.playerOneSelection = 2;
            SceneManager.LoadScene("PlayerSelectionTwo");
        }
        else
        {
            TwoPlayer.playerTwoSelection = 2;
            SceneManager.LoadScene(level);
        }
    }
}
