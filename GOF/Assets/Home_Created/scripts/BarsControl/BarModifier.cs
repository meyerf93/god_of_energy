using UnityEngine;
using System.Collections.Generic;

public class BarModifier : MonoBehaviour 
{
	public List<Modifier> modifiers = new List<Modifier>();

	public int moneyDefaultModifier;
	public int ecoDefaultModifier;
	public int comfortDefaultModifier;

	void Start()
	{
		modifiers.Add(new Modifier("first elem", 0,0,0));
	}
	public int getCount()
	{
		return modifiers.Count;
	}

	public int addToModifiers(Modifier modifier)
	{
		modifiers.Add (modifier);
		return modifiers.IndexOf (modifier);
	}
	public bool removeFromModifiers(int index)
	{
		if (index > 0 && index < modifiers.Count) {
			modifiers.RemoveAt (index);
			return true;
		} else
			return false;

	}
	public void clear ()
	{
		modifiers.Clear ();
	}
	public float getMoneyModifier()
	{
		float value = moneyDefaultModifier;

		foreach (Modifier modifier in modifiers) 
		{
			if (modifier.activated) 
			{
				value += modifier.moneyValue;
			}

		}
		return value;
	}
	public float getEcoModifier()
	{
		float value = ecoDefaultModifier;

		foreach (Modifier modifier in modifiers) 
		{
			if (modifier.activated) 
			{
				value += modifier.ecoValue;
			}
		}
		return value;
	}
	public float getComfortModifier()
	{
		float value = comfortDefaultModifier;

		foreach (Modifier modifier in modifiers) 
		{
			if (modifier.activated) 
			{
				value += modifier.comfortValue;
			}
		}
		return value;
	}
}
