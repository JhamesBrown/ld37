﻿using UnityEngine;
using System.Collections;

public class RocketMiniGame : MonoBehaviour {


	private Animator rocketAni;

	private float timeTillLanding;

	public float targetX;
	private bool isTargetSet;

	public float playerX;

	void Start(){
		rocketAni = GameObject.Find ("Rocket_01").GetComponent<Animator> ();
	}

	void Update () {
		timeTillLanding = ResourceManager.nextLandingTime - Time.time;

		if (timeTillLanding < 20f && !isTargetSet) {
			targetX = Random.Range (0.0f, 1.0f);
			isTargetSet = true;
			rocketAni.SetBool("startLandingSeq",true);
		}


		if (timeTillLanding < 0.0f) {
			if (Mathf.Abs(targetX - playerX) < 0.1f) {
				landingSuccessful ();
			} else {
				landingFailed ();
			}
			rocketAni.SetBool("startLandingSeq",false);
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
