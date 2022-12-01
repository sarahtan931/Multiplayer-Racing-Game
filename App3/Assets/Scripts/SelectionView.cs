using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionView : MonoBehaviour
{
    public Image goldImage;
    public Image silverImage;
    public Sprite locked;
    public Button goldButton;
    public Button silverButton;
    void Start()
    {
        TMPro.TMP_Text goldStats = GameObject.Find("GoldStats").GetComponent<TMPro.TMP_Text>();
        TMPro.TMP_Text silverStats = GameObject.Find("SilverStats").GetComponent<TMPro.TMP_Text>();

        if (!PlayerName.ownsGold)
        {
            goldStats.text = "Locked";
            goldImage.sprite = locked;
            goldButton.gameObject.SetActive(false);
        }

        if (!PlayerName.ownsSilver)
        {
            silverStats.text = "Locked";
            silverImage.sprite = locked;
            silverButton.gameObject.SetActive(false);
        }
    }

}
