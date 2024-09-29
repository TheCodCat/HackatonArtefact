using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTorch : Torch
{
	[SerializeField] bool _isFire;
	[SerializeField] private LightDoor _door;
	[SerializeField] private ColorDoor _doorColor;
	public void Interaction(Gradient gradient, ColorDoor colorDoor, Color lightColor)
	{
		if(_isFire) return;

		_isFire = true;
		base.Interaction();
		_doorColor = colorDoor;
		var color = _particleSystem.colorOverLifetime;
		color.color = gradient;
		_light.color = lightColor;
		_door.Interaction(this);
	}
	public void DisableLight()
	{
		_isFire = false;
		Interaction();
	}
	public ColorDoor Getcolor()
	{
		return _doorColor;
	}
}
