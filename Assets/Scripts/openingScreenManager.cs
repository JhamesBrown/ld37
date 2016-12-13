using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class openingScreenManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit ();
		}
		if (Input.GetKeyDown(KeyCode.F2) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			SceneManager.LoadScene (1);
		}

	}
}
