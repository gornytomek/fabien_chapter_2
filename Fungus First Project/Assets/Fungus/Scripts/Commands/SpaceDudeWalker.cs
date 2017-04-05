using UnityEngine;
using System.Collections;
using System;


public class SpaceDudeWalker : Walker {

	public float speed = 5f;
	private Animator anim;
	private bool facingRight;

	// Use this for initialization
	void Start () {       
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

		Debug.Log("Walk to Pint is:" + walkToPoint);

		if (walkToPoint != null)
		{
			if (transform.position != walkToPoint)
			{
				transform.position = Vector3.MoveTowards(transform.position, walkToPoint, speed * Time.deltaTime);
			}
			else
			{
				anim.SetBool("Walking", false);
				DoneWalk();
			}
		}

	}

	protected override void StartWalk()
	{
		if (walkToPoint.x < transform.position.x)
		{
			FaceLeft();
		}
		else
		{
			FaceRight();
		}

		anim.SetBool("Walking", true);
	}

	public override void FaceLeft()
	{
		transform.localRotation = Quaternion.Euler(0, 180, 0);
	}

	public override void FaceRight()
	{
		transform.localRotation = Quaternion.Euler(0, 0, 0);
	}
}