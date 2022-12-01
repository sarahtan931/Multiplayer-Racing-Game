using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    private string level;

    private void Start()
    {
        if(PlayerName.levelSelection == 1)
        {
            level = "GameScene";
        }
        else if (PlayerName.levelSelection == 2)
        {
            level = "GameScene2";
        }
    }
    public void GreenSelected()
    {
        PlayerName.playerSelection = 0;
        SceneManager.LoadScene(level);
    }

    public void SilverSelected()
    {
        PlayerName.playerSelection = 1;
        SceneManager.LoadScene(level);
    }

    public void GoldSelected()
    {
        PlayerName.playerSelection = 2;
        SceneManager.LoadScene(level);
    }
}
