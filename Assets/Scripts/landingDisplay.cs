using UnityEngine;
using System.Collections;

public class landingDisplay : MonoBehaviour {

	private GameObject resourceManager;
	private string displayText;


	// Use this for initialization
	void Start () {
		resourceManager = GameObject.Find ("ResourceManager");
	
	}
	
	// Update is called once per frame
	void Update () {

		displayText = "NEXT ROCKET \n LANDING : " + resourceManager.GetComponent<ResourceManager> ().landingTimeText; 
		GetComponent<TextMesh> ().text = displayText;
		
	}
}
