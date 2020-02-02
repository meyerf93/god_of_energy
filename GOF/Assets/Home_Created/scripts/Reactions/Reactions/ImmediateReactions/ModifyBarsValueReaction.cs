using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModifyBarsValueReaction : Reaction 
{
	public Toggle toggle;
	public string modifierDescription;
	public Slider moneyModifierSlider;
	public Slider ecoModifierSlider;
	public Slider comfortModifierSlider;
	private BarModifier barsModifier;
	private int index = -1;

	protected override void SpecificInit()
	{
		barsModifier = FindObjectOfType<BarModifier> ();
	}
	protected override void ImmediateReaction()
	{
		if (toggle != null)
		{
			if (toggle.isOn) {
				if (index == -1) {
					index = barsModifier.addToModifiers (new Modifier (modifierDescription, moneyModifierSlider.value, ecoModifierSlider.value, comfortModifierSlider.value));
				}
				else
				{
					Debug.LogError ("an object was already added");
				}

			} 
			else 
			{
				if (index == -1 || !barsModifier.removeFromModifiers (index)) 
				{
					Debug.LogError ("failed to remove");
				}
				index = -1;
			}
		}
	}
	public int getModifierIndex()
	{
		return index;
	}

}
