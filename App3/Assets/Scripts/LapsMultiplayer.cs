using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LapsMultiplayer : MonoBehaviour
{
    public TMPro.TMP_Text playerOneLap;
    public TMPro.TMP_Text playerTwoLap;
    public GameObject line;
    public GameObject player;
    public int lapTotal;
    private int lapCountOne = 1;
    private int lapCountTwo = 1;

    // Update is called once per frame
    void Update()
    {
        playerOneLap.text = string.Format("Laps: {0}/{1}", lapCountOne, lapTotal);
        playerTwoLap.text = string.Format("Laps: {0}/{1}", lapCountTwo, lapTotal);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hello");
        if(other.gameObject.tag == "finish" && (player.name == "Player" || player.name == "Player 1" || player.name == "Player 2"))
        {
            lapCountOne++;
        }

        if(other.gameObject.tag == "finish" && (player.name == "Player 3" || player.name == "Player 4" || player.name == "Player 5"))
        {
            lapCountTwo++;
        }

        if(lapCountOne > lapTotal)
        {
            TwoPlayer.firstPlayerWon = true;
            SceneManager.LoadScene("MultiplayerWin");
        }

        if(lapCountTwo > lapTotal)
        {
            SceneManager.LoadScene("MultiplayerWin");
        }
    }
}
