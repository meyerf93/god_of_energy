using UnityEditor;

[CustomEditor(typeof(BathroomUsageReaction))]
public class BathroomUsageReactionEditor : ReactionEditor 
{
	protected override string GetFoldoutLabel ()
	{
		return "bathroom usage Reaction";
	}

}
