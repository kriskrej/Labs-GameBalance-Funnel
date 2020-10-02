using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] public class Game {
    [SerializeField] List<Level> levels;

    public void CreateRandomLevels(int levelCount) {
        levels = new List<Level>();
        for (int i = 0; i < levelCount; ++i)
            CreateRandomLevel();
    }

    void CreateRandomLevel() {
        levels.Add(Level.CreateRandom());
    }

    public void ShowCurrentFunnel(LevelsUI levelsUi) {
        var levelTestingResults = GenerateTestingResults(levels);
        levelsUi.ShowLevels(levelTestingResults);
    }

    List<LevelTestingResult> GenerateTestingResults(List<Level> levels) {
        var ret = new List<LevelTestingResult>();
        foreach (var level in levels) {
            ret.Add(new LevelTestingResult(level));
        }

        for (int p = 0; p< 1000; p++) {
            var player = CreateRandomPlayer();
            for (int i = 0; i < levels.Count; ++i)
                if (player.WouldStartNextLevel(levels[i]))
                    ret[i].score += 0.001f;
        }

        return ret;
    }

    Player CreateRandomPlayer() {
        var ret = new Player();
        ret.skill = Random.Range(0f, 1f);
        ret.znudzenie = Random.Range(0f, 1f);
        ret.gaveUp = false;
        return ret;
    }
}

class Player {
    public bool gaveUp = false;
    public float skill;
    public float znudzenie;

    public bool WouldStartNextLevel(Level level) {
        if (gaveUp)
            return false;
        if (Random.Range(0f, level.difficulty01) > Random.Range(0f, skill*1.7f)) {
            gaveUp = true;
        }

        skill += level.difficulty01 / 10;
        return true;
    }
}

public class LevelTestingResult {
    public Level level;
    public float score = 0;

    public LevelTestingResult(Level level) {
        this.level = level;
    }
}