using UnityEngine;
using System.Collections;
using Fungus;

[CommandInfo("Walker", "Face Direction", "Turns the walker to face the specified direction.")]
public class FaceDirectionCommand : Command {

	public enum Facing
	{
		Left,Right
	}

	public Walker walker;
	public Facing turnToFace;

	public override void OnEnter()
	{
		if (turnToFace == Facing.Left)
		{
			walker.FaceLeft();
		}

		if (turnToFace == Facing.Right)
		{
			walker.FaceRight();
		}

		Continue();
	}


	public override string GetSummary()
	{
		if (walker == null)
		{
			return "Error: No walker object selected";
		}

		return "Face " + walker.name + " " + turnToFace;
	}

	public override Color GetButtonColor()
	{
		return new Color32(216, 191,216, 255);
	}

}