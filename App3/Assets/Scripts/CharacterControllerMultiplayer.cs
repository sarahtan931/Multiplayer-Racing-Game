using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerMultiplayer : MonoBehaviour
{
    public GameObject green1;
    public GameObject silver1;
    public GameObject gold1;
    public GameObject green2;
    public GameObject silver2;
    public GameObject gold2;
    void Start()
    {
        if (TwoPlayer.playerOneSelection == 0)
        {
            silver1.SetActive(false);
            gold1.SetActive(false);
        }
        else if (TwoPlayer.playerOneSelection == 1)
        {
            green1.SetActive(false);
            gold1.SetActive(false);
        }
        else if (TwoPlayer.playerOneSelection == 2)
        {
            green1.SetActive(false);
            silver1.SetActive(false);
        }

        if (TwoPlayer.playerTwoSelection == 0)
        {
            silver2.SetActive(false);
            gold2.SetActive(false);
        }
        else if (TwoPlayer.playerTwoSelection == 1)
        {
            green2.SetActive(false);
            gold2.SetActive(false);
        }
        else if (TwoPlayer.playerTwoSelection == 2)
        {
            green2.SetActive(false);
            silver2.SetActive(false);
        }
    }
}
