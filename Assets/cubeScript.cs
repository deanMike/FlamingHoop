using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

    TuningVariables variables;

	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material.color = Color.white;
        variables = GameObject.Find("TuningVariables").GetComponent<TuningVariables>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown() {
        if (int.Parse(this.gameObject.tag) == variables.winningNum) {
            this.GetComponent<Renderer>().material.color = Color.green;
            variables.win = true;
        }
        this.GetComponent<Renderer>().material.color = Color.red;
    }
}
