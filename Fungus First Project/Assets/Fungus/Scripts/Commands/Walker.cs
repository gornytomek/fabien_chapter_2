using UnityEngine;
using System.Collections;
using Fungus;

public abstract class Walker : MonoBehaviour {

	protected Vector3 walkToPoint;
	protected Command callingCommand;

	void Awake()
	{
		walkToPoint = transform.position;
	}


	public void WalkTo(Transform walkTo,Command caller)
	{
		if (callingCommand != null)
		{
			callingCommand.StopParentBlock();
			callingCommand = null;
		}

		walkToPoint = walkTo.position;        
		StartWalk();
		callingCommand = caller;
	}

	protected abstract void StartWalk();
	public abstract void FaceLeft();
	public abstract void FaceRight();

	protected void DoneWalk()
	{
		if (callingCommand != null)
		{
			callingCommand.Continue();
			callingCommand = null;
		}
	}



}