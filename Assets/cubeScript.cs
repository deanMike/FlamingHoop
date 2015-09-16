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
        if (name == variables.appendix) {
            GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("WIN!");
            variables.win = true;
        } else {
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }


}
