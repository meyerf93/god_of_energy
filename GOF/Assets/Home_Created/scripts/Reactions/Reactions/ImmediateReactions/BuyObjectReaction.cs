using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Reflection;

public class BuyObjectReaction : Reaction 
{
	public LastBoughtObject lastObject;
	public int objectPrize;
	public Toggle toggle;
	public shopConditionsManager shopConditionsManager;
	public Condition linkedCondition;
	public string modifierDescription;
	public Slider moneyModifierSlider;
	public Slider ecoModifierSlider;
	public Slider comfortModifierSlider;

	private int index = -1;
	private BarModifier barsModifier;
	private MoneyController moneyController;

	protected override void SpecificInit ()
	{
		moneyController = FindObjectOfType<MoneyController> ();
		barsModifier = FindObjectOfType<BarModifier> ();
	}

	protected override void ImmediateReaction ()
	{

		if (toggle.isOn) 
		{
			if (moneyController.buyShopObject (objectPrize)) {				
				shopConditionsManager.onPurchase (linkedCondition);
				lastObject.newObjectBought (toggle);
				if (index == -1) 
				{
					index = barsModifier.addToModifiers (new Modifier (modifierDescription, moneyModifierSlider.value, ecoModifierSlider.value, comfortModifierSlider.value));
				} 
				else 
				{
					Debug.LogError ("an object was already added");
				}
			} 
			else 
			{
				toggle.onValueChanged.SetPersistentListenerState (0, UnityEventCallState.Off);
				toggle.isOn = false;
				toggle.onValueChanged.SetPersistentListenerState (0, UnityEventCallState.RuntimeOnly);

				if (lastObject.getLastBoughtObject () != null) 
				{
					lastObject.getLastBoughtObject ().onValueChanged.SetPersistentListenerState (0, UnityEventCallState.Off);
					lastObject.getLastBoughtObject ().isOn = true;
					lastObject.getLastBoughtObject ().onValueChanged.SetPersistentListenerState (0, UnityEventCallState.RuntimeOnly);
				}

			}
		} 
		else 
		{
			if (index == -1 || !barsModifier.removeFromModifiers (index)) 
			{
				
			}
			index = -1;
		}

	}


}
