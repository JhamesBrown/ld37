using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

	public static float population;
	public float heat;

	public float timeTillLanding;
	public string landingTimeText;
	private float landingPeriod = 35f;
	public static float nextLandingTime;
	private float timeSinceMeltdown;
	private float batteryDecayPerSecond = 1.0f;

	public float lifeSupportBattery;


	public enum powerUse {
		PoweredRocketLander,
		PoweredLifeSupportCharger
	};

	public static powerUse currentPowerUse;

	void Start () 
	{
		population = 120;
		nextLandingTime = 35f;
		currentPowerUse = powerUse.PoweredLifeSupportCharger;
		lifeSupportBattery = 0.5f;
		
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

		if (population < 0) {
			population = 0;
		}
		disasterPopulationModifier (heat);
		disasterPopulationModifier (1.0f  - lifeSupportBattery);
		ManagePowerSupply ();
		// life suport population increase added here maybe

	}

	private void ManagePowerSupply(){
		float decrementRate = ((batteryDecayPerSecond / 60)/ (1/Time.fixedDeltaTime));
		if (lifeSupportBattery - decrementRate > 0.0f){
			lifeSupportBattery -= decrementRate;
		}
		float maxBatChargeRate = 2.0f; // per minute
		maxBatChargeRate = ((( 1 + (maxBatChargeRate * heat)) /60)/ (1/Time.fixedDeltaTime)); // max gorwth per time slice
		if (currentPowerUse == powerUse.PoweredLifeSupportCharger) {
			if (lifeSupportBattery < 1) {
				lifeSupportBattery += maxBatChargeRate;
			}
		} else if (currentPowerUse == powerUse.PoweredRocketLander) {
			// do nothing, but rocket lander is activated
		}
	}

	private void disasterPopulationModifier(float modifier){
		float populationGrowth = 0;
		float maxPopGrowth = 60; // per minute
		maxPopGrowth = (((maxPopGrowth /60)/ 60)/ (1/Time.fixedDeltaTime)); // max gorwth per time slice
		if (modifier < 0.8f) {
			//do nothing
		}
		else if ( modifier < 0.99f) {
			populationGrowth = -maxPopGrowth;
			timeSinceMeltdown = Time.time;
		} else{
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
