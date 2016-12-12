using UnityEngine;
using System.Collections;

public class EastWallBehaviour : MonoBehaviour {


	static float ZeroPos = 1.0f;
	static float MaxPos = -1.0f;
    static float progress = 0;

	private Collider sliderRail;

	void Start () {
		resetSliderPosToCenter ();
		sliderRail = GetComponentInParent<Collider> ();

		ZeroPos = sliderRail.bounds.min.x;
		MaxPos = sliderRail.bounds.max.x;
	}

	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3(Mathf.Lerp (ZeroPos, MaxPos, progress),transform.localPosition.y,transform.localPosition.z);
	}

	public static void resetSliderPosToCenter(){
		progress = MaxPos + ((ZeroPos - MaxPos) / 2.0f);
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

	void OnTriggerEnter(Collider other) {
		Debug.Log("East wall collision Enter");
	}
	void OnTriggerExit(Collider other) {
		Debug.Log("East wall collision Exit");
	}
	void OnTriggerStay(Collider other) {
		Debug.Log("East wall collision Stay");
	}
}
