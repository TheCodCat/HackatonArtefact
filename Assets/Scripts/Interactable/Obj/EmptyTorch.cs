using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTorch : Torch
{
	[SerializeField] protected bool _isStart;
	private void Start()
	{
		if (_isStart) Interaction();
	}
	public override void Interaction()
    {
        base.Interaction();
    }
}
