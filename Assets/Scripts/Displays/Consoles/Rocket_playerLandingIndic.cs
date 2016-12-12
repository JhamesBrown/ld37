using UnityEngine;
using System.Collections;

public class Rocket_playerLandingIndic : MonoBehaviour {


	private Vector2 PlayerProg;
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
		PlayerProg.x = GetComponentInParent<RocketMiniGame> ().playerX;

		pos.x = Mathf.Lerp (-0.45f, 0.45f, PlayerProg.x);

		transform.localPosition = new Vector3(pos.x, transform.localPosition.y, transform.localPosition.z);

	}
}
