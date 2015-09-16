using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TuningVariables : MonoBehaviour {

    public int gameLength;
    public int redFontTimeThreshold;
    public int gridWidth;
    public int gridHeight;
    public string startButtonText;
    public string tuningVariablesButtonText;
    public bool variablesSaved = false;
    public bool win = false;
    public int winningNum;
    public System.Random winner = new System.Random();
    public int cubeNum = 1;

    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start() {
        
    }


    public void ResetVariables() {
        gameLength = 10;
        redFontTimeThreshold = 5;
        gridWidth = 8;
        gridHeight = 5;
        startButtonText = "Start";
        tuningVariablesButtonText = "Tuning Variables";
    }
}
