using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game {
    List<Level> levels = new List<Level>();
    public void CreateRandomLevels(int levelCount) {
        for (int i = 0; i < levelCount; ++i)
            CreateRandomLevel();
    }

    void CreateRandomLevel() {
        levels.Add(Level.CreateRandom());
    }

    public void ShowUI(LevelsUI firstMonth) {
        firstMonth.ShowLevels(levels);
    }
}