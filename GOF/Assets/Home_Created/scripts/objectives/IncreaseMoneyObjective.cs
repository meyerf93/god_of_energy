using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMoneyObjective : ObjectiveInterface {

	public int incrementValue;
	public MoneyController moneyController;

	private int startValue;

	// Use this for initialization
	public void onLevelStart () 
	{
		startValue = (int)moneyController.getValue ();
	}

	override public bool check()
	{
		if (moneyController.getValue () - startValue < incrementValue) 
		{
			return false;
		}
		return true;
	}
}
