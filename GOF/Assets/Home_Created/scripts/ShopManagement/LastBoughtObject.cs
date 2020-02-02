using UnityEngine.UI;
using UnityEngine;

public class LastBoughtObject : MonoBehaviour 
{
	private Toggle toggle;

	void Start()
	{
		
	}

	public Toggle getLastBoughtObject()
	{
		return toggle;
	}

	public void newObjectBought(Toggle toggle)
	{
		this.toggle = toggle;
	}

}
