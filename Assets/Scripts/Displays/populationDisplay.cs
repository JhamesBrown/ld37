using UnityEngine;
using System.Collections;

public class populationDisplay : MonoBehaviour {

	private string displayText;

	void Update () {

		displayText = "Population : " + Mathf.Floor(ResourceManager.population); 
		GetComponent<TextMesh> ().text = displayText;

	}
}
