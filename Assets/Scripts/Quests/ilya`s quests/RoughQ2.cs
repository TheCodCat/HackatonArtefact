using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoughQ2 : Rough
{
	[SerializeField] private Quest2Manager _quest;
	[SerializeField] private int _index;
	public override void Activate()
	{
		base.Activate();
	}

	public override void Interaction()
	{
		base.Interaction();
		_quest.Interaction(_index);
	}
}
