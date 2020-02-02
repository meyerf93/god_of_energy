using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour {

	public float targetTime;
	public ReactionCollection timeUpObjectivesAchieved;
	public ReactionCollection timeUpObjectivesFailed;
	public ReactionCollection left30;
	public ReactionCollection left20;
	public ReactionCollection left10;

	private LevelManagement levelManagement;
	private IncreaseEcoObjective ieo;
	private IncreaseMoneyObjective imo;

	void Start()
	{
		levelManagement = FindObjectOfType<LevelManagement> ();
		ieo = FindObjectOfType<IncreaseEcoObjective> ();
		imo = FindObjectOfType<IncreaseMoneyObjective> ();
		ieo.onLevelStart ();
		imo.onLevelStart ();
	}
	void Update () 
	{
		targetTime -= Time.deltaTime;
		if ((int)targetTime == 30) 
		{
			timeLeft30();	
		} 
		else if ((int)targetTime == 20) 
		{
			timeLeft20 ();
		}
		else if ((int)targetTime == 10) 
		{
			timeLeft10 ();
		}
		if (targetTime <= 0.0f)
		{
			timerEnded();
		}

	}
	private void timerEnded()
	{
		if (levelManagement.checkLevelObjectivesAchieved ()) {
			timeUpObjectivesAchieved.React ();
			levelManagement.unlockNextLevel ();
		} else {
			timeUpObjectivesFailed.React ();
		}
	}
	private void timeLeft30()
	{
		left30.React ();
	}
	private void timeLeft20()
	{
		left20.React ();
	}
	private void timeLeft10()
	{
		left10.React ();
	}
}
