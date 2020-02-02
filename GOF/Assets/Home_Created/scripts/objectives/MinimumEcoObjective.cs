using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimumEcoObjective : ObjectiveInterface {

	public int minimumValue;

	public EcoController ecoController;

	// Use this for initialization
	void Start () {

	}

	override public bool check()
	{
		if (ecoController.getValue () < minimumValue) 
		{
			return false;
		}
		return true;
	}
}
