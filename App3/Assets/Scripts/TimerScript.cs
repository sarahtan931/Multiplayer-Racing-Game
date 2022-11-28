using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

    public static TimerScript instance = null;
    public static float timeRemaining = 180;
    public static bool timerIsRunning = true;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);

            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                PlayerName.gameComplete = true;
                SceneManager.LoadScene("OnePlayerLeaderboard");
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        TMPro.TMP_Text timeText = GameObject.Find("TimerText").GetComponent<TMPro.TMP_Text>();
        if (timeText.text != null)
        {
            float minutes = Mathf.FloorToInt(timeRemaining / 60);
            float seconds = Mathf.FloorToInt(timeRemaining % 60);
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

    }
}
