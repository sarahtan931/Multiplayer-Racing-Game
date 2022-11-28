using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace App2.Scoreboards
{

    public class ScoreboardEntryUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI entryNameText;
        [SerializeField] private TextMeshProUGUI entryScoreText;

        public void Initialise(ScoreboardEntryData scoreboardEntryData)
        {
            entryNameText.text = scoreboardEntryData.entryName;
            entryScoreText.text = scoreboardEntryData.entryScore.ToString();
        }
    }
}