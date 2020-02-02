using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlockManager : MonoBehaviour {

	public ReactionCollection startReactionCollection;
	public ReactionCollection LockedReactionCollection;

	private LevelManagement levelManager;

	void Start()
	{
		levelManager = FindObjectOfType<LevelManagement> ();
	}
	public void onLevelStartClick()
	{
		if (levelManager.checkUnlocked ()) 
		{
			startReactionCollection.React ();
		} 
		else 
		{
			LockedReactionCollection.React ();
		}
	}

}
