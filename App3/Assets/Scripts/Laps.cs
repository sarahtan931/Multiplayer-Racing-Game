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
        Debug.Log("count" + lapCount);
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
                    SceneManager.LoadScene("OnePlayerLeaderboard");
                }

                if (SceneManager.GetActiveScene().name == "GameScene2")
                {
                    SceneManager.LoadScene("OnePlayerLeaderboard2");
                }


            }
        }
    }
}
