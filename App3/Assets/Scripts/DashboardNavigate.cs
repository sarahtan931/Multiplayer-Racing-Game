using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DashboardNavigate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Home()
    {
        PlayerName.gameComplete = false;
        TimerScript.timeRemaining = 180;
        SceneManager.LoadScene("OnePlayerMainMenu");
    }
}
