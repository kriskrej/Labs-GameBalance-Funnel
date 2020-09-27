using UnityEngine;

public class Main : MonoBehaviour {
    [SerializeField] LevelsUI firstMonth;

    void Start() {
        var game = new Game();
        game.CreateRandomLevels(10);
        game.ShowUI(firstMonth);
    }

}