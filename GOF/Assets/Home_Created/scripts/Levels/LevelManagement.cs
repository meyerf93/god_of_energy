using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagement : MonoBehaviour {

	private int levelChoice;
	public LevelObjective[] levelObjectives;

	// Use this for initialization
	void Start () 
	{
		levelChoice = 0;
		levelObjectives [0].unlock ();
		levelObjectives [0].display();
	}

	public void next()
	{
		if (levelChoice < levelObjectives.Length - 1) 
		{
			levelChoice++;
		}

		levelObjectives [levelChoice].display ();
	}

	public void previous()
	{
		if (levelChoice > 0) 
		{
			levelChoice--;
		}

		levelObjectives [levelChoice].display ();
	}

	public bool checkLevelObjectivesAchieved()
	{
		return levelObjectives [levelChoice].checkObjectives ();
	}
	public bool checkUnlocked()
	{
		return levelObjectives [levelChoice].checkUnlocked ();
	}
	public void unlockNextLevel()
	{
		levelObjectives [levelChoice + 1].unlock ();
	}
	

}
