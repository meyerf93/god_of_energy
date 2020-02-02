using UnityEngine;

public class MoneyController : MonoBehaviour {

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
		value = value + time*barModifier.getMoneyModifier ();
		if ((int)value == MAX/4) 
		{
			lowReaction.React ();
		}
		if ((int)value == MAX/10) 
		{
			veryLowReaction.React ();
		}
		if((int)value < 0)
		{
			noMoreReaction.React ();
		}
	}

	public bool buyShopObject(int prize)
	{
		if ((value - prize) < 0) 
		{
			return false;
		} else 
		{
			value -= prize;
			return true;
		}
	}
}
