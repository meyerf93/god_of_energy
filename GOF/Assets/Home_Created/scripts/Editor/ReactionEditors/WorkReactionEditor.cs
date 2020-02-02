using UnityEditor;

[CustomEditor(typeof(WorkReaction))]
public class WorkReactionEditor : ReactionEditor 
{
	protected override string GetFoldoutLabel ()
	{
		return "Work Reaction";
	}

}
