using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayer : MonoBehaviour
{
    public static TwoPlayer instance = null;
    public static bool gameComplete = false;
    public static int playerOneSelection = 1;
    public static int playerTwoSelection = 2;
    public static int levelSelection = 0;
    public static bool firstPlayerWon = false;


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
