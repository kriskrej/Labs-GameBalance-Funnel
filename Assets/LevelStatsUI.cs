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

    public void Setup(Level level) {
        LevelName = level.name;
        percentBar.Percent = Random.Range(0f, 1f);
    }
}