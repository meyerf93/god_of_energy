using UnityEngine;

public class WorkManager : MonoBehaviour {

	public float targetTime;
	public int workIncrement;
	public ReactionCollection workEndReaction;
	public ReactionCollection workStartReaction;

	private int workModifierID = 0;
	private bool activated = false;
	private BarModifier barModifier;

	void Start()
	{
		barModifier = FindObjectOfType<BarModifier> ();
	}
	public void workStart () 
	{
		if (targetTime > 0) 
		{
			activated = true;
			workModifierID = barModifier.addToModifiers(new Modifier("WorkToDo",workIncrement,0,-2));
			workStartReaction.React ();
		}
	}

	public bool isOn()
	{
		return activated;
	}

	public void workEnd()
	{
		activated = false;
		barModifier.removeFromModifiers(workModifierID);
		workModifierID = 0;
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
					workEnd ();
					workFinished ();

				}
			} 
			else 
			{
				activated = false;
			}
		}			
	}
	public void workFinished()
	{
		workEndReaction.React();
	}
}
