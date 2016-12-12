﻿using UnityEngine;
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
		max.x = 0.45f; // Bounds weren't working so I put this in manually after eyeballing the world space values
		min.x = -0.45f;
	}

	void Update () {
		TargetProg.x = GetComponentInParent<RocketMiniGame> ().targetX;

		pos.x = Mathf.Lerp (min.x, max.x, TargetProg.x);

		transform.localPosition = new Vector3(pos.x, transform.localPosition.y, transform.localPosition.z);

	}
}
