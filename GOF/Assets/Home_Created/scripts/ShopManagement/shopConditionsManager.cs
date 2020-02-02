using UnityEngine;
using UnityEngine.UI;

public class shopConditionsManager : MonoBehaviour {

	public void onPurchase(Condition linkedCondition)
	{
		linkedCondition.satisfied = GetComponent<Toggle> ().isOn;
	}
}
