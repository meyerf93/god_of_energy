using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseEcoObjective : ObjectiveInterface {

	public int incrementValue;
	public EcoController ecoController;

	private int startValue;

	// Use this for initialization
	public void onLevelStart () 
	{
		startValue = (int)ecoController.getValue ();
	}

	override public bool check()
	{
		if (ecoController.getValue () - startValue < incrementValue) 
		{
			return false;
		}
		return true;
	}
}
