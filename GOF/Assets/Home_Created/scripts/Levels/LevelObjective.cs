using UnityEngine;
using UnityEngine.UI;

public class LevelObjective : MonoBehaviour {

	public ObjectiveInterface[] objectivesToCheck;
	public Objective[] objectives;
	public Text levelObjectivesText;

	private bool unlocked = false;

	public void display()
	{
		string textToDisplay = "Level objectives : \n\n";

		for (int i = 0; i < objectives.Length; i++) 
		{
			textToDisplay += objectives [i].text;
			textToDisplay += "\n";
		}

		levelObjectivesText.text = textToDisplay;
	}

	public bool checkObjectives()
	{
		for (int i = 0; i < objectivesToCheck.Length; i++) 
		{
			if (!objectivesToCheck [i].check ()) {
				return false;
			}
		}
		return true;
	}

	public void unlock()
	{
		unlocked = true;
	}

	public bool checkUnlocked()
	{
		return unlocked;
	}
}
