using UnityEngine;
using System.Collections;

public class Rocket_targetLandingIndic : MonoBehaviour {


	private Vector2 TargetProg;
	private Vector2 pos;
	private Vector2 max;
	private Vector2 min;
	private Collider ConsoleScreenGraph;

	// Use this for initialization
	void Start () {
		ConsoleScreenGraph = GetComponentInParent<Collider> ();
		max = new Vector2 (ConsoleScreenGraph.bounds.max.x, ConsoleScreenGraph.bounds.max.y);
		min = new Vector2 (ConsoleScreenGraph.bounds.min.x, ConsoleScreenGraph.bounds.min.y);
	}
	
	// Update is called once per frame
	void Update () {
		TargetProg.x = GetComponentInParent<RocketMiniGame> ().targetX;

		pos.x = Mathf.Lerp (min.x, max.x, TargetProg.x);

		transform.localPosition = new Vector3(pos.x, transform.localPosition.y, transform.localPosition.z);

	}
}
