using UnityEngine;
using UnityEngine.UI;

public class BoughtShopObjects : MonoBehaviour 
{

	private Toggle[] boughtObjects = {null,null,null,null,null,null,null};

	public void setToggle(int index, Toggle toggle)
	{
		boughtObjects [index] = toggle;
	}
	public Toggle getToggle(int index)
	{
		return boughtObjects [index];
	}

}
