using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {

    TuningVariables variables;
    GameObject StartText;
    GameObject TuningText;

    string inputGameLength;
    string inputRedTime;
    string inputGridWidth;
    string inputGridHeight;
    string inputStart;
    string inputTuning;


    void Start() {
        StartText = GameObject.Find("StartText");
        TuningText = GameObject.Find("TuningText");
        variables = GameObject.Find("TuningVariables").GetComponent<TuningVariables>();
        if (!variables.variablesSaved) {
            variables.ResetVariables();
        }
        if (Application.loadedLevelName == "StartScreen") {
            StartText.GetComponent<Text>().text = variables.startButtonText;
            TuningText.GetComponent<Text>().text = variables.tuningVariablesButtonText;
        }
        inputGameLength = variables.gameLength.ToString();
        inputRedTime = variables.redFontTimeThreshold.ToString();
        inputGridWidth = variables.gridWidth.ToString();
        inputGridHeight = variables.gridHeight.ToString();
        inputStart = variables.startButtonText;
        inputTuning = variables.tuningVariablesButtonText;
    }

    void Update() {
        if (Application.loadedLevelName == "StartScreen") {
            StartText.GetComponent<Text>().text = variables.startButtonText;
            TuningText.GetComponent<Text>().text = variables.tuningVariablesButtonText;
        }
        Debug.Log(variables.gameLength.ToString());
    }
    public void OnGUI() {
        if (Application.loadedLevelName == "TuningVariables") {
            inputGameLength = GUI.TextField(new Rect(600, 250, 25, 20), inputGameLength);
            inputRedTime = GUI.TextField(new Rect(600, 270, 25, 20), inputRedTime.ToString());
            inputGridWidth = GUI.TextField(new Rect(600, 290, 25, 20), inputGridWidth.ToString());
            inputGridHeight = GUI.TextField(new Rect(600, 310, 25, 20), inputGridHeight.ToString());
            inputStart = GUI.TextField(new Rect(600, 330, 200, 20), inputStart);
            inputTuning = GUI.TextField(new Rect(600, 350, 200, 20), inputTuning);

        }
    }
    public void LoadGame() {
        Application.LoadLevel("Gameplay");
    }
    public void LoadTuning() {
        Application.LoadLevel("TuningVariables");
    }
    public void LoadMenu() {
        Application.LoadLevel("StartScreen");
    }

    public void SaveVariables() {
        variables.variablesSaved = true;
        variables.gameLength = int.Parse(inputGameLength);
        variables.redFontTimeThreshold = int.Parse(inputRedTime);
        variables.gridWidth = int.Parse(inputGridWidth);
        variables.gridHeight = int.Parse(inputGridHeight);
        variables.startButtonText = inputStart;
        variables.tuningVariablesButtonText = inputTuning;
    }
}
