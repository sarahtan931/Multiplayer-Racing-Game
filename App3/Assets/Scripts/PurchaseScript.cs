using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PurchaseScript : MonoBehaviour
{
    public void purchaseGold()
    {
        if(!PlayerName.ownsGold && PlayerName.totalCoins >= 50)
        {
            PlayerName.ownsGold = true;
            PlayerName.totalCoins -= 50;
        }
        else if (PlayerName.ownsGold)
        {
            Debug.Log("You already own this car!");
        }
        else if (PlayerName.totalCoins < 50)
        {
            Debug.Log("You don't have enough coins!");
        }
    }

    public void purchaseSilver()
    {
        if(!PlayerName.ownsSilver && PlayerName.totalCoins >= 20)
        {
            PlayerName.ownsSilver = true;
            PlayerName.totalCoins -= 20;
        }
        else if(PlayerName.ownsSilver)
        {
            Debug.Log("You already own this car!");
        }
        else if(PlayerName.totalCoins < 20)
        {
            Debug.Log("You don't have enough coins!");
        }
    }

    public void returnMain()
    {
        SceneManager.LoadScene("OnePlayerMain");
    }
}
