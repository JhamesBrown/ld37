using UnityEngine;
using System.Collections;

public class reactorLerp : MonoBehaviour {

	public float progress;
	public float ZeroPos = -0.6f;
	public float FinalPos = 0.0065f;

	// Use this for initialization
	void Start () {
		progress = 0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3(0.0f, Mathf.Lerp (ZeroPos, FinalPos, progress),0.0f);
	}
}
