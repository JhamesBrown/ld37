using UnityEngine;
using System.Collections;

public class Rocket_playerLandingIndic : MonoBehaviour {


	private Vector2 PlayerProg;
	private Vector2 pos;
	private Vector2 max;
	private Vector2 min;

	void Start () {
		max = new Vector2(0.45f,0.45f); // Bounds weren't working so I put this in manually after eyeballing the world space values
		min = new Vector2(-0.45f, -0.45f);
	}

	void Update () {
		PlayerProg = new Vector2(GetComponentInParent<RocketMiniGame> ().playerX, GetComponentInParent<RocketMiniGame> ().playerY);
		pos = new Vector2(Mathf.Lerp (min.x, max.x, PlayerProg.x),Mathf.Lerp (min.y, max.y, PlayerProg.y));
		transform.localPosition = new Vector3(pos.x, pos.y, transform.localPosition.z);
	}
}
