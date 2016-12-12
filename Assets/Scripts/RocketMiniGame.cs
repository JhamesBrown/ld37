using UnityEngine;
using System.Collections;

public class RocketMiniGame : MonoBehaviour {


	private float timeTillLanding;

	public float targetX;
	private bool isTargetSet;

	public float playerX;



	void Update () {
		timeTillLanding = ResourceManager.nextLandingTime - Time.time;

		if (timeTillLanding < 20f && !isTargetSet) {
			targetX = Random.Range (0.0f, 1.0f);
			isTargetSet = true;
		}


		if (timeTillLanding < 0.0f) {
			if (Mathf.Abs(targetX - playerX) < 0.1f) {
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
	}

	void landingFailed()
	{
		Debug.Log ("FAILLLLL");
		ResourceManager.population -= 10;
	}

}
