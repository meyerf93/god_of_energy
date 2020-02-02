using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenUsageReaction : Reaction {

	public TimedKitchenUsage kitchenUsageManager;

	protected override void SpecificInit()
	{

	}
	protected override void ImmediateReaction()
	{
		kitchenUsageManager.kitchenUsageStart();
	}
}
