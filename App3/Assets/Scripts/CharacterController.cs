using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject green;
    public GameObject silver;
    public GameObject gold;
    void Start()
    {
        if(PlayerName.playerSelection == 0)
        {
            silver.SetActive(false);
            gold.SetActive(false);
        } 
        else if(PlayerName.playerSelection == 1)
        {
            green.SetActive(false);
            gold.SetActive(false);
        }
        else if (PlayerName.playerSelection == 2)
        {
            green.SetActive(false);
            silver.SetActive(false);
        }
    }
}

