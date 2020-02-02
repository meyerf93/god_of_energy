using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiersActivationReaction : DelayedReaction {

	public string modifierName;
	private BarModifier barModifier;

	protected override void SpecificInit()
	{
		barModifier = FindObjectOfType<BarModifier> ();
	}

	protected override void ImmediateReaction()
	{
		foreach (Modifier modifier in barModifier.modifiers) 
		{
			if (modifier.description == modifierName) 
			{
				modifier.activate ();
				return;
			}
		}
	}
}
