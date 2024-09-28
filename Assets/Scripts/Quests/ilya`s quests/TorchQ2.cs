using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchQ2 : Torch
{
	[SerializeField] private bool IsStart;

	private void Start()
	{
		if (IsStart) Interaction();
	}
	public override void Interaction()
	{
		base.Interaction();
	}
	public bool GetIsPlay()
	{
		return IsPlay;
	}
}
