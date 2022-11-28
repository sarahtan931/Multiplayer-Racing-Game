using System;
using System.Collections;
using System.Collections.Generic;
using App3.Scoreboards;
using UnityEngine;

namespace App3.Scoreboards
{
    [Serializable]
    public class ScoreboardSaveData
    {
        public List<ScoreboardEntryData> highscores = new List<ScoreboardEntryData>();
    }

}