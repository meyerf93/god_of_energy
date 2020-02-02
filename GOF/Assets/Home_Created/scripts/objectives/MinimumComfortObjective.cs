using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimumComfortObjective : ObjectiveInterface {

	public int minimumValue;

	public ConfortController confortController;
	// Use this for initialization
	void Start () {
		
	}
	
	override public bool check()
	{
		if (confortController.getValue () < minimumValue) 
		{
			return false;
		}
		return true;
	}
}
