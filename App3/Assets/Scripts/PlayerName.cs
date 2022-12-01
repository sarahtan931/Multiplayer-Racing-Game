using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public static PlayerName instance = null;
    public static string finalPlayerName;
    public static bool gameComplete = false;
    public static int totalCoins = 0;
    public static int tempCoins = 0;
    public static bool ownsGold = false;
    public static bool ownsSilver = false;
    public static int playerSelection = 0;
    public static int levelSelection = 0;

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
