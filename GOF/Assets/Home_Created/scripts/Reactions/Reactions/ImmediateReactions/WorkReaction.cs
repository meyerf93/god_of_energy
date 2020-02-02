using UnityEngine;

public class WorkReaction : Reaction {

	public WorkManager workManager;

	protected override void SpecificInit()
	{
		
	}
	protected override void ImmediateReaction()
	{
		workManager.workStart();
	}
}
