using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedBathroomUsage : MonoBehaviour {

	public float targetTime;
	public int comfortIncrement;

	public ReactionCollection bathroomUsageEndReaction;
	public ReactionCollection bathroomUsageStartReaction;

	private int bathroomUsageModifierID = 0;
	private bool activated = false;
	private BarModifier barModifier;

	// Use this for initialization
	void Start () 
	{
		barModifier = FindObjectOfType<BarModifier> ();
	}
	
	public void bathroomUsageStart () 
	{
		if (targetTime > 0) 
		{
			activated = true;
			bathroomUsageModifierID = barModifier.addToModifiers(new Modifier("bathroomUsage",0,0,comfortIncrement));
			bathroomUsageStartReaction.React ();
		}
	}

	public bool isOn()
	{
		return activated;
	}

	public void bathroomUsageEnd()
	{
		activated = false;
		barModifier.removeFromModifiers(bathroomUsageModifierID);
		bathroomUsageModifierID = 0;
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
					bathroomUsageEnd ();
					bathroomUsageFinished ();

				}
			} 
			else 
			{
				activated = false;
			}
		}			
	}
	public void bathroomUsageFinished()
	{
		bathroomUsageEndReaction.React();
	}
}
