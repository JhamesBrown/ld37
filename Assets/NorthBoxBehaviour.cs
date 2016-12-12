using UnityEngine;
using System.Collections;

public class NorthBoxBehaviour : MonoBehaviour {
	public Renderer renderer;
	void Start () {
		renderer = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		if (ResourceManager.currentPowerUse == ResourceManager.powerUse.PoweredLifeSupportCharger) {
			renderer.material.color = Color.red;
		} else {

			renderer.material.color = Color.green;
		}
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("North wall collision Enter");
	}
	void OnTriggerExit(Collider other) {
		Debug.Log("North wall collision Exit");
	}
	void OnTriggerStay(Collider other) {
		Debug.Log("North wall collision Stay");
	}
		
}
