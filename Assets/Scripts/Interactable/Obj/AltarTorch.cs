using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarTorch : EmptyTorch
{
	[SerializeField] private ColorDoor _colorDoor;
	public ColorDoor ColorDoor => _colorDoor;
	public override void Interaction()
	{
		if (_isStart)
		{
			base.Interaction();
			_isStart = false;
		}
	}
	public Gradient GetGradient()
	{
		return _particleSystem.colorOverLifetime.color.gradient;
	}
	public Color GetColor()
	{
		return _light.color;
	}
}