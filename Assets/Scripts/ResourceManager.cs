using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

	public static int population;

	public float powerOutput;
	public float heat;

	public float timeTillLanding;
	public string landingTimeText;
	public static float nextLandingTime;
	private float landingPeriod = 90f;


	void Start () 
	{
		population = 120;
		nextLandingTime = 25f;
	
	}

	void Update () 
	{
		heat = reactorLerp.progress;
		timeTillLanding = nextLandingTime - Time.time;
		landingTimeText = landingTimeTextFormat (timeTillLanding);

		if (timeTillLanding <= 0.0f) {
			nextLandingTime = Time.time + landingPeriod;
		}
	}


	string landingTimeTextFormat(float t)
	{
		int min = Mathf.FloorToInt(t/60);
		int sec = Mathf.FloorToInt(t) - (min * 60);

		return min + ":" + sec; 
	}
}
