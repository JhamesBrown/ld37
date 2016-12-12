using UnityEngine;
using System.Collections;

public class Rocket_targetLandingIndic : MonoBehaviour {


	private Vector2 TargetProg;
	private Vector2 pos;
	private Vector2 max;
	private Vector2 min;
	// private Collider ConsoleScreenGraph;

	void Start () {
		// ConsoleScreenGraph = GetComponentInParent<Collider> ();
		// max = new Vector2 (ConsoleScreenGraph.bounds.max.x, ConsoleScreenGraph.bounds.max.y);
		// min = new Vector2 (ConsoleScreenGraph.bounds.min.x, ConsoleScreenGraph.bounds.min.y);
		max = new Vector2(0.45f,0.45f); // Bounds weren't working so I put this in manually after eyeballing the world space values
		min = new Vector2(-0.45f, -0.45f);
	}

	void Update () {
		TargetProg = new Vector2(GetComponentInParent<RocketMiniGame> ().targetX,GetComponentInParent<RocketMiniGame> ().targetY);

		pos = new Vector2(Mathf.Lerp (min.x, max.x, TargetProg.x), Mathf.Lerp (min.y, max.y, TargetProg.y));

		transform.localPosition = new Vector3(pos.x, pos.y, transform.localPosition.z);

	}
}
