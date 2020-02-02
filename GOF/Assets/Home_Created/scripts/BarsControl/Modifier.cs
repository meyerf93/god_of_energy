using UnityEngine;

public class Modifier
{
	public string description;
	public bool activated = false;
	public float moneyValue;
	public float ecoValue;
	public float comfortValue;

	public Modifier(string desc,float money,float eco,float comfort )
	{
		this.description = desc;
		this.moneyValue = money;
		this.ecoValue = eco;
		this.comfortValue = comfort;
	}
	public void activate()
	{
		activated = true;
	}

	public void desactivate()
	{
		activated = false;
	}


}
