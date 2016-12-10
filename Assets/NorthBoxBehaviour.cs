using UnityEngine;
using System.Collections;

public class NorthBoxBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
