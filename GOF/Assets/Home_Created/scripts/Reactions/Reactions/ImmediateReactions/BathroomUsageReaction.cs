using UnityEngine;

public class BathroomUsageReaction : Reaction {

	public TimedBathroomUsage bathroomUsageManager;

	protected override void SpecificInit()
	{

	}
	protected override void ImmediateReaction()
	{
		bathroomUsageManager.bathroomUsageStart ();
	}
}
