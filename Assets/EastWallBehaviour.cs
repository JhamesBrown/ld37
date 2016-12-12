using UnityEngine;
using System.Collections;

public class EastWallBehaviour : MonoBehaviour {


	private float ZeroPos;
	private float MaxPos;
    private float progress;

	private Collider sliderRail;

	void Start () {
		sliderRail = GetComponentInParent<Collider> ();
		ZeroPos = sliderRail.bounds.min.x * 3f;
		MaxPos = sliderRail.bounds.max.x * 3f;


		//resetSliderPosToCenter ();
	}

	// Update is called once per frame
	void Update () {
		progress = Mathf.InverseLerp (MaxPos,ZeroPos, transform.position.x);
	}


	/*
	public static void resetSliderPosToCenter(){
		//progress = MaxPos + ((ZeroPos - MaxPos) / 2.0f);
	}
	

	public static bool updateSliderPos(float delta){
		delta /= 100.0f;
		Debug.Log ("slider pos delta = " + delta);
		if (progress+delta < MaxPos || progress + delta > ZeroPos ){
			return false;
		}
		progress += delta;
		return true;
	}
	*/


	public void scrubSlider(Vector3 pos)
	{
		Vector3 newPos = new Vector3(Mathf.Clamp(pos.x,ZeroPos,MaxPos),transform.position.y,transform.position.z);
		transform.position = newPos;
		GetComponentInParent<RocketMiniGame> ().playerX = progress;

	}

	/*
	void OnTriggerEnter(Collider other) {
		Debug.Log("East wall collision Enter");
	}
	void OnTriggerExit(Collider other) {
		Debug.Log("East wall collision Exit");
	}
	void OnTriggerStay(Collider other) {
		Debug.Log("East wall collision Stay");
	}
	*/
}
