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
		if (Physics.Raycast(ray, out hit, 1.0F)){
			Debug.Log("There is something in front of the object!" + hit.collider.name);
		}
	}
}
