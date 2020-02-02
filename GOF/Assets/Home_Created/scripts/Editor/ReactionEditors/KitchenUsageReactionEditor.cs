using UnityEditor;

[CustomEditor(typeof(KitchenUsageReaction))]
public class KitchenUsageReactionEditor : ReactionEditor 
{
	protected override string GetFoldoutLabel ()
	{
		return "Kitchen usage Reaction";
	}

}
