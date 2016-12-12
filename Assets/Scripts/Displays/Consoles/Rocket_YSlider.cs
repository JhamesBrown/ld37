using UnityEngine;
using System.Collections;

public class Rocket_YSlider : MonoBehaviour {

	private float ZeroPos;
	private float MaxPos;
	private float progress;

	private Collider sliderRail;

	void Start () {
		sliderRail = GetComponentInParent<Collider> ();
		ZeroPos = sliderRail.bounds.min.x * 3f;
		MaxPos = sliderRail.bounds.max.x * 3f;
	}

	void Update () {
		progress = Mathf.InverseLerp (MaxPos,ZeroPos, transform.position.x);
	}

	public void scrubSlider(Vector3 pos)
	{
		if (ResourceManager.currentPowerUse == ResourceManager.powerUse.PoweredRocketLander) {
			Vector3 newPos = new Vector3 (Mathf.Clamp (pos.x, ZeroPos, MaxPos), transform.position.y, transform.position.z);
			transform.position = newPos;
			GetComponentInParent<RocketMiniGame> ().playerY = progress;
		}

	}
}
