using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {

		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast (Camera.main.transform.position, fwd, 1)) { 
			print ("There is something in front of the object!");
		}

	}
}
