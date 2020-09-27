using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsUI : MonoBehaviour {
    [SerializeField] LevelStatsUI levelStatsUiPrefab;

    void Start() {
        levelStatsUiPrefab.gameObject.SetActive(false);
    }

    public void AddLevel(Level level) {
        var newLevel = Instantiate(levelStatsUiPrefab, transform);
        newLevel.gameObject.SetActive(true);
        newLevel.Setup(level);
    }

    public void ShowLevels(List<Level> levels) {
        foreach (var level in levels) {
            AddLevel(level);
        }
    }
}
