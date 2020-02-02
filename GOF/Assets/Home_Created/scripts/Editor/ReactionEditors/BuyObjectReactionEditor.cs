using UnityEditor;

[CustomEditor(typeof(BuyObjectReaction))]
public class BuyObjectReactionEditor : ReactionEditor
{
	protected override string GetFoldoutLabel ()
	{
		return "Buy object Reaction";
	}
}
