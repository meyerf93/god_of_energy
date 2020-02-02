using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedKitchenUsage : MonoBehaviour {

	public float targetTime;
	public int comfortIncrement;

	public ReactionCollection kitchenUsageEndReaction;
	public ReactionCollection kitchenUsageStartReaction;

	private int kitchenUsageModifierID = 0;
	private bool activated = false;
	private BarModifier barModifier;

	// Use this for initialization
	void Start () 
	{
		barModifier = FindObjectOfType<BarModifier> ();
	}
	
	public void kitchenUsageStart () 
	{
		if (targetTime > 0) 
		{
			activated = true;
			kitchenUsageModifierID = barModifier.addToModifiers(new Modifier("kitchenUsage",0,0,comfortIncrement));
			kitchenUsageStartReaction.React ();
		}
	}

	public bool isOn()
	{
		return activated;
	}

	public void kitchenUsageEnd()
	{
		activated = false;
		barModifier.removeFromModifiers(kitchenUsageModifierID);
		kitchenUsageModifierID = 0;
	}
	// Update is called once per frame
	void Update () 
	{
		if (activated) 
		{
			if (targetTime >= 0) 
			{
				targetTime -= Time.deltaTime;
				if (targetTime < 0) 
				{
					kitchenUsageEnd ();
					kitchenUsageFinished ();

				}
			} 
			else 
			{
				activated = false;
			}
		}			
	}
	public void kitchenUsageFinished()
	{
		kitchenUsageEndReaction.React();
	}
}
