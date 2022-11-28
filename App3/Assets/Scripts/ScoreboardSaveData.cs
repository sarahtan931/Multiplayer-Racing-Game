using System;
using System.Collections;
using System.Collections.Generic;
using App2.Scoreboards;
using UnityEngine;

namespace App2.Scoreboards
{
    [Serializable]
    public class ScoreboardSaveData
    {
        public List<ScoreboardEntryData> highscores = new List<ScoreboardEntryData>();
    }

}