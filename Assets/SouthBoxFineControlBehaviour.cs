using UnityEngine;
using System.Collections;

public class SouthBoxFineControlBehaviour : SouthBoxBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public static bool updateSliderPos(float delta){
		delta *= 30.0f;
		Debug.Log ("slider pos delta = " + delta);

		reactorLerp.SetProgress (-0.0015f);
		return true;
	}
}
