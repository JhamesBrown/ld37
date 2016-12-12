using UnityEngine;
using System.Collections;

public class populationDisplay : MonoBehaviour {

	//private GameObject resourceManager;
	private string displayText;


	// Use this for initialization
	void Start () {
		//resourceManager = GameObject.Find ("ResourceManager");

	}

	// Update is called once per frame
	void Update () {

		displayText = "Population : " + ResourceManager.population; 
		GetComponent<TextMesh> ().text = displayText;

	}
}
