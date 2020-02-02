using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class shopPersistency : MonoBehaviour {

	public Toggle toggle;
	public LastBoughtObject lastBoughtObject;
	public Condition condition;
	void Start () 
	{
		toggle.onValueChanged.SetPersistentListenerState(0,UnityEventCallState.Off);
		toggle.isOn = condition.satisfied;
		if (condition.satisfied) 
		{
			lastBoughtObject.newObjectBought (toggle);
		}
		toggle.onValueChanged.SetPersistentListenerState(0,UnityEventCallState.RuntimeOnly);
	}
}
