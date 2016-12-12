using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

<<<<<<< ddbe061d7abb99e822e82ade74ae463b6428133f
	public static int population;

=======
	public static float population;
>>>>>>> game concept code for population growth with the nuclear reactor
	public float powerOutput;
	public float heat;

	public float timeTillLanding;
	public string landingTimeText;
<<<<<<< ddbe061d7abb99e822e82ade74ae463b6428133f
	public static float nextLandingTime;
	private float landingPeriod = 90f;
=======
	private static float nextLandingTime;
	private float timeSinceMeltdown;
>>>>>>> game concept code for population growth with the nuclear reactor


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
			populationGrowth = -(((maxPopGrowth /60)/ 60)/ (1/Time.fixedDeltaTime));
			timeSinceMeltdown = Time.time;
		} else {
			populationGrowth = -0.2f - ((Time.time - timeSinceMeltdown));
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
