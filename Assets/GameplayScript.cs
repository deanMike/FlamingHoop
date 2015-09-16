using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameplayScript : MonoBehaviour {

    TuningVariables variables;
    GameObject timer;
    private float timeRemaining;
    private int width;
    private int height;
    private bool found = false;
    public Transform prefab;

    public Material Green, Red;

    

	// Use this for initialization
	void Start () {
        variables = GameObject.Find("TuningVariables").GetComponent<TuningVariables>();
        timer = GameObject.Find("Timer");
        timeRemaining = variables.gameLength;
        
        for (int x = 180; x < 180 + variables.gridWidth; x++) {
            for (int y = 325; y < 325 + variables.gridHeight; y++) {
                Instantiate(prefab);
                prefab.localScale = new Vector3(50, 50, 50);
                prefab.transform.position = new Vector3(((x - 179) * 60) + 90, ((y - 324) * 60) + 16, -28);
                prefab.gameObject.tag = variables.cubeNum.ToString();
                variables.cubeNum++;
            }
        }
        variables.winningNum = variables.winner.Next(variables.cubeNum);

    }

    // Update is called once per frame
    void Update() {
        if (timeRemaining > 0) {
            timer.GetComponent<Text>().text = timeRemaining.ToString("n0");
            timeRemaining -= Time.deltaTime;
        }
        if (timeRemaining < variables.redFontTimeThreshold) {
            timer.GetComponent<Text>().color = Color.red;
        }
        if (timeRemaining <= 0) {
            Application.LoadLevel("GameSummary");
        }
        if (variables.win) {
            Application.LoadLevel("GameSummary");
        }
    
    }
}
