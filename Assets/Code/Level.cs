using UnityEngine;

public class Level {
    public string name;
    public float difficulty01;
    public float timeConsuming01;
    public float fun01;
    public float polished01;

    public static Level CreateRandom() {
        var lvl = new Level();
        lvl.name = LevelNameGenerator.PickRandom();
        lvl.difficulty01 = Random.Range(0f, 1f);
        lvl.timeConsuming01 = Random.Range(0f, 1f);
        lvl.fun01 = Random.Range(0f, 1f);
        lvl.polished01 = Random.Range(0f, 1f);
        return lvl;
    }
}