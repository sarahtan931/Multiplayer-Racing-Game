using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public TMPro.TMP_Text wintext;
    // Start is called before the first frame update
    void Start()
    {
        int win = 2;
        if (TwoPlayer.firstPlayerWon)
        {
            win = 1;
        }

        wintext.text = string.Format("Player {0} wins!", win);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
