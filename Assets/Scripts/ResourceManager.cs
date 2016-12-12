using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

	public static float population;
	public float powerOutput;
	public float heat;

	public float timeTillLanding;
	public string landingTimeText;
	private float landingPeriod = 90f;
	public static float nextLandingTime;
	private float timeSinceMeltdown;


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

	void FixedUpdate (){
		float populationGrowth = 0;
		float maxPopGrowth = 60; // per minute
		maxPopGrowth = (((maxPopGrowth /60)/ 60)/ (1/Time.fixedDeltaTime)); // max gorwth per time slice
		if (heat < 0.2f) {
			populationGrowth = maxPopGrowth * 0.1f;
		} else if (heat < 0.8f) {
			populationGrowth = maxPopGrowth;
		} else if (heat < 0.99f) {
			populationGrowth = -maxPopGrowth;
			timeSinceMeltdown = Time.time;
		} else {
			populationGrowth = -maxPopGrowth - ((Time.time - timeSinceMeltdown) * 0.0001f);
		}
		population = population + population * populationGrowth;


	}


	string landingTimeTextFormat(float t)
	{
		int min = Mathf.FloorToInt(t/60);
		int sec = Mathf.FloorToInt(t) - (min * 60);

		return min + ":" + sec; 
	}
}
