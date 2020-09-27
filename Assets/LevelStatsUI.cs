using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelStatsUI : MonoBehaviour {
    [SerializeField] TMP_Text levelName;

    public string LevelName {
        get => levelName.text;
        set => levelName.text = value;
    }

    public void Setup(Level level) {
        LevelName = level.name;
    }
}