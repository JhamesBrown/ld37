using UnityEngine;
using System.Collections;

public class NorthBoxBehaviour : MonoBehaviour {
	public Renderer renderer;
	public Color currentColor;
	void Start () {
		renderer = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		renderer.material.color = currentColor;
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
