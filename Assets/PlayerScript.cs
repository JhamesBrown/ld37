using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {

		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		Ray ray = new Ray(Camera.main.transform.position, fwd);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 1.5F)){
			Debug.Log("There is something in front of the object!" + hit.collider.name);
			if (Input.GetMouseButtonDown(0)) {
				
				Component[] components = hit.collider.gameObject.GetComponents(typeof(NorthBoxBehaviour));
				if (components.Length == 0) {
					return;
				}
				NorthBoxBehaviour consoleButton = (NorthBoxBehaviour)components [0];
				if (consoleButton.currentColor == Color.red) {
					consoleButton.currentColor = Color.green;
				} else {
					consoleButton.currentColor = Color.red;
				}
			}
		}
	}
}
