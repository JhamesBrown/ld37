using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// bool trackEastDeltas = false;
	bool trackSouthDeltas = false;
	Quaternion previousRotation = Quaternion.identity;
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
			//Debug.Log("There is something in front of the object!" + hit.collider.name);
			if (Input.GetMouseButtonDown(0)) {
				
				Component[] norths = hit.collider.gameObject.GetComponents(typeof(NorthBoxBehaviour));
				if (norths.Length != 0) {
					processNorth (norths);
				}

				Component[] souths = hit.collider.gameObject.GetComponents(typeof(SouthBoxBehaviour));
				if (souths.Length != 0) {
					processSouth (souths);
				}

				Component[] easts = hit.collider.gameObject.GetComponents(typeof(EastWallBehaviour));
				if (easts.Length != 0) {
					//trackSlider (true);
					scrubSlider(hit.collider.gameObject, hit.point);
				}
				Component[] southFine = hit.collider.gameObject.GetComponents(typeof(SouthBoxFineControlBehaviour));
				if (southFine.Length != 0) {
					trackSouthDeltas = true;

				}
			}

			if (Input.GetMouseButton(0)) {
				Component[] easts = hit.collider.gameObject.GetComponents(typeof(EastWallBehaviour));
				if (easts.Length != 0) {
					scrubSlider(hit.collider.gameObject, hit.point);
				}
			}
		}
		/*
		if (trackEastDeltas) {
			if (Input.GetMouseButtonUp (0)) {
				trackEastDeltas = false;
				previousRotation = Quaternion.identity;
				EastWallBehaviour.resetSliderPosToCenter ();
			} else {
				if (previousRotation == Quaternion.identity) {
					previousRotation = Camera.main.transform.rotation;
				}

				float delta = 0.0f;
				delta = Camera.main.transform.rotation.eulerAngles.y - previousRotation.eulerAngles.y;
				Debug.Log (Camera.main.transform.rotation.eulerAngles.x+ " "  +
					Camera.main.transform.rotation.eulerAngles.y + " "  + Camera.main.transform.rotation.eulerAngles.z );
				EastWallBehaviour.updateSliderPos (delta);
				previousRotation = Camera.main.transform.rotation;
			}
		}
		*/
		if (trackSouthDeltas) {
			if (Input.GetMouseButtonUp (0)) {
				trackSouthDeltas = false;
				previousRotation = Quaternion.identity;

			} else {
				if (previousRotation == Quaternion.identity) {
					previousRotation = Camera.main.transform.rotation;
				}

				float delta = 0.0f;
				delta = Camera.main.transform.rotation.eulerAngles.y - previousRotation.eulerAngles.y;
				Debug.Log (Camera.main.transform.rotation.eulerAngles.x+ " "  +
					Camera.main.transform.rotation.eulerAngles.y + " "  + Camera.main.transform.rotation.eulerAngles.z );
				SouthBoxFineControlBehaviour.updateSliderPos (delta);
				previousRotation = Camera.main.transform.rotation;
			}
		}
	}

	/*
	void trackSlider (bool track){
		EastWallBehaviour.resetSliderPosToCenter ();
		trackEastDeltas = true;
	}
	*/

	void scrubSlider(GameObject col , Vector3 pos){
		col.GetComponent<EastWallBehaviour> ().scrubSlider (pos);
	}

	void processSouth(Component[] components){
		SouthBoxBehaviour consoleButton = (SouthBoxBehaviour)components [0];
		if (consoleButton.currentColor == Color.red) {
			consoleButton.avertNuclearDisaster ();
		}
	}

	void processNorth(Component[] components){
		NorthBoxBehaviour consoleButton = (NorthBoxBehaviour)components [0];
		if (consoleButton.currentColor == Color.red) {
			consoleButton.currentColor = Color.green;
		} else {
			consoleButton.currentColor = Color.red;
		}
	}
}
