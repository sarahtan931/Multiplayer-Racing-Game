using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinsDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TMPro.TMP_Text coinText = GameObject.Find("CoinsText").GetComponent<TMPro.TMP_Text>();

        if (SceneManager.GetActiveScene().name == "GameScene" || SceneManager.GetActiveScene().name == "GameScene2")
        {
            coinText.text = string.Format("Coins: {0}", PlayerName.tempCoins);
        }
        else
        {
            coinText.text = string.Format("Coins: {0}", PlayerName.totalCoins);
        }
        
    }
}
