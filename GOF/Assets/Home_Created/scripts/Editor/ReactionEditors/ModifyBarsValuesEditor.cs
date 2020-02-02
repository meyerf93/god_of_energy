using UnityEditor;

[CustomEditor(typeof(ModifyBarsValueReaction))]
public class ModifyBarsValueEditor : ReactionEditor
{
	protected override string GetFoldoutLabel ()
	{
		return "Modify Bars Reaction";
	}
}
