using UnityEngine;
using System.Collections;

public class reactorLerp : MonoBehaviour {

	public static float progress;
	public static float ZeroPos = -0.6f;
	public float FinalPos = 0.0065f;

	// Use this for initialization
	void Start () {
		progress = 0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3(0.0f, Mathf.Lerp (ZeroPos, FinalPos, progress),0.0f);
	}

	void FixedUpdate (){
		progress += 0.0005f;
	}

	public void SetProgress(float newProgressValue){
		progress = newProgressValue;
	}
}
