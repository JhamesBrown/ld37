using UnityEngine;
using System.Collections;

public class RocketMiniGame : MonoBehaviour {


	private float timeTillLanding;

	public float targetX;
	private bool isTargetSet;

	public int playerX;

	private bool gameComplete;

	// Use this for initialization
	void Start () {
		
	}

	void OnEnable() {
		gameComplete = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeTillLanding < 20f && !isTargetSet) {
			targetX = Random.Range (0.0f, 1.0f);
			isTargetSet = true;
		}


		if (Mathf.Abs(targetX - playerX) < 0.1f) {
			gameComplete = true;
		}




		if (timeTillLanding < 0.0f) {
			if (gameComplete) {
				landingSuccessful ();
			} else {
				landingFailed ();
			}
		}
	}

	void landingSuccessful()
	{
		Debug.Log ("landing successful");
		ResourceManager.population += 50;
		gameObject.SetActive (false);
	}

	void landingFailed()
	{
		Debug.Log ("FAILLLLL");
		ResourceManager.population -= 10;
	}

}
