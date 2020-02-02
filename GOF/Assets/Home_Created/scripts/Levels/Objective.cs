using UnityEngine;

public class Objective : MonoBehaviour 
{
	public bool isAchieved;
	public string text;

	public void setAchieved(bool achieved)
	{
		isAchieved = achieved;
	}

}
