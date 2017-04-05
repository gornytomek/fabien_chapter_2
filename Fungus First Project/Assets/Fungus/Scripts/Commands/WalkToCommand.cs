using UnityEngine;
using System.Collections;
using Fungus;

[CommandInfo("Walker","Walk To","Walks the walker to the specified target")]
public class WalkToCommand : Command {

	[Tooltip("GameObject that we want to do the walking. Must have a Walker component.")]
	public Walker walker;
	[Tooltip("Target that we want the walker to walk to")]
	public Transform target;

	public override void OnEnter()
	{
		walker.WalkTo(target, this);       
	}

	public override string GetSummary()
	{
		if (walker == null)
		{
			return "Error: No walker object selected";
		}

		if (target == null)
		{
			return "Error: No target object selected";
		}

		return "Walk " + walker.name + " to location of " + target.name;
	}

	public override Color GetButtonColor()
	{
		return new Color32(216, 191, 216, 255);
	}

}