using UnityEngine;
using System.Collections;

public class SouthBoxBehaviour : MonoBehaviour {

	public Renderer renderer;
	public Color currentColor;
	float dial = 1.0f;
	static float ZeroPos = 1.0f;
	static float MaxPos = -1.0f;
	void Start () {
		renderer = GetComponent<Renderer> ();
		currentColor = Color.red;
	}

	// Update is called once per frame
	void Update () {
		currentColor = Color.Lerp (Color.green, Color.red, dial);
		renderer.material.color = currentColor;
	}
	void FixedUpdate(){
		if (dial < 1.0f) {
			dial += 0.01f;
		}
	}

	public void avertNuclearDisaster(){
		reactorLerp.progress = 0;
		dial = 0f;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("South wall collision Enter");
	}
	void OnTriggerExit(Collider other) {
		Debug.Log("South wall collision Exit");
	}
	void OnTriggerStay(Collider other) {
		Debug.Log("South wall collision Stay");
	}
}
