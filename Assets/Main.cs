using Sirenix.OdinInspector;
using UnityEngine;

public class Main : MonoBehaviour {
    [SerializeField] LevelsUI iterationResultsPrefab;
    [SerializeField] Transform iterationsContainer;
    //[SerializeField] Transform 

    [SerializeField] Game game;
    
    void Start() {
        game = new Game();
        game.CreateRandomLevels(20);
        ShowNextIterationResults();
    }

    [Button]
    void ShowNextIterationResults() {
        var iterationResults = Instantiate(iterationResultsPrefab, iterationsContainer);
        game.ShowCurrentFunnel(iterationResults);
    }
}