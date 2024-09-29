using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorTorch : Torch
{
	[SerializeField] private UnityEvent _colorChangedEvent;
	[SerializeField] bool _isFire;
	[SerializeField] private ColorDoor _doorColor;
	public bool Interaction(Gradient gradient, ColorDoor colorDoor)
	{
		if(_isFire || colorDoor != _doorColor) return false;

		_isFire = true;
		base.Interaction();
		_doorColor = colorDoor;
		var color = _particleSystem.colorOverLifetime;
		color.color = gradient;
		_colorChangedEvent?.Invoke();
		return true;
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
