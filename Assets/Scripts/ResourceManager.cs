using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

	public static int population;
	public float powerOutput;
	public float heat;
	public float timeTillLanding;
	public string landingTimeText;
	private static float nextLandingTime;


	// Use this for initialization
	void Start () {
		population = 120;
		nextLandingTime = 25f;
	
	}
	
	// Update is called once per frame
	void Update () {
		heat = reactorLerp.progress;
		timeTillLanding = nextLandingTime - Time.time;
		landingTimeText = landingTimeTextFormat (timeTillLanding);
	}


	string landingTimeTextFormat(float t)
	{
		int min = Mathf.FloorToInt(t/60);
		int sec = Mathf.FloorToInt(t) - (min * 60);

		return min + ":" + sec; 
	}
}
