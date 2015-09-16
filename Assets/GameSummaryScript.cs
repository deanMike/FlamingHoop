using UnityEngine;
using System.Collections;

public class GameSummaryScript : MonoBehaviour {

    TuningVariables variables;
    public GameObject victory;
    public GameObject failure;

	// Use this for initialization
	void Start () {
        variables = GameObject.Find("TuningVariables").GetComponent<TuningVariables>();
        victory = GameObject.Find("Victory");
        failure = GameObject.Find("Defeat");



        if (variables.win) {
            victory.SetActive(true);
            failure.SetActive(false);
            variables.win = false;
        } else {
            failure.SetActive(true);
            victory.SetActive(false);
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadMenu() {
        Application.LoadLevel("StartScreen");
    }
}
