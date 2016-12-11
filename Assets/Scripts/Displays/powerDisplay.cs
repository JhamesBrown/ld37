using UnityEngine;
using System.Collections;

public class powerDisplay : MonoBehaviour {


	private ResourceManager resourceManager;
	private string displayText;


	// Use this for initialization
	void Start () {
		resourceManager = GameObject.Find ("ResourceManager").GetComponent<ResourceManager>();

	}

	// Update is called once per frame
	void Update () {

		displayText = "POWER OUTPUT \n" + resourceManager.powerOutput +
			"%\nHEAT :" + Mathf.FloorToInt(resourceManager.heat * 100f) + "%";
		GetComponent<TextMesh> ().text = displayText;

	}
}
