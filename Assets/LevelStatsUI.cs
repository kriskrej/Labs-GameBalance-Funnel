using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelStatsUI : MonoBehaviour {
    [SerializeField] TMP_Text levelName;
    [SerializeField] PercentBar percentBar;

    public string LevelName {
        get => levelName.text;
        set => levelName.text = value;
    }

    public void Setup(LevelTestingResult level) {
        LevelName = level.level.name;
        percentBar.Percent = level.score;
    }
}