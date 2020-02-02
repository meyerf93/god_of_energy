using UnityEngine;

public class ConfortController : MonoBehaviour {

	public BarModifier barModifier;
	public int MAX;
	private float value;
	public ReactionCollection lowReaction;
	public ReactionCollection veryLowReaction;
	public ReactionCollection noMoreReaction;


	void Start()
	{
		value = (float)MAX;
	}
	public float getValue()
	{
		return value;
	}

	public void barUpdate (float time)
	{
		value = value + time*barModifier.getComfortModifier ();
		if ((int)value == MAX/4) 
		{
			lowReaction.React ();
		}
		if ((int)value == MAX/10) 
		{
			veryLowReaction.React ();
		}
		if((int)value <= 0)
		{
			noMoreReaction.React ();
		}
	}
}


