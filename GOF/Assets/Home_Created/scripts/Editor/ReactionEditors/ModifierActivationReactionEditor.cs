using UnityEditor;

[CustomEditor(typeof(ModifiersActivationReaction))]
public class ModifierActivationReactionEditor : ReactionEditor
{
	protected override string GetFoldoutLabel ()
	{
		return "Modifiers Activation Reaction";
	}
}
