using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laps : MonoBehaviour
{
    public GameObject lapLine;
    public TMPro.TMP_Text lapText;
    public int lapTotal;
    private int lapCount = 1;
 
    void Update()
    {
        lapText.text = string.Format("Laps: {0}/{1}", lapCount, lapTotal);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerCar")
        {
            Debug.Log(lapCount + " " + lapTotal);
            lapCount++;

            if(lapCount > lapTotal)
            {
                PlayerName.gameComplete = true;
                if (SceneManager.GetActiveScene().name == "GameScene")
                {
                    PlayerName.totalCoins += PlayerName.tempCoins;
                    PlayerName.tempCoins = 0;
                    SceneManager.LoadScene("OnePlayerLeaderboard");
                }

                if (SceneManager.GetActiveScene().name == "GameScene2")
                {
                    PlayerName.totalCoins += PlayerName.tempCoins;
                    PlayerName.tempCoins = 0;
                    SceneManager.LoadScene("OnePlayerLeaderboard2");
                }


            }
        }
    }
}
