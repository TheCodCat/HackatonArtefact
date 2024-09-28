using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDoor : Interactable
{
	[SerializeField] private bool _isOpen;
	[SerializeField] private GameObject _door;
	[SerializeField] private List<DoorTorch> _gradients;
	[SerializeField] private ColorDoor _gradient;
	[SerializeField] private int _countFire;
	public void Interaction(DoorTorch doorTorch)
	{
		if (_isOpen) return;

		_gradients.Add(doorTorch);
		if (_gradients.Count != 2) return;

		for (int i = 0; i < _gradients.Count; i++)
		{
			if (_gradients[i].Getcolor() == _gradient) _countFire++;
		}

		if (_countFire != _gradients.Count)
		{
			foreach (var item in _gradients)
			{
				item.DisableLight();
			}
		}
		else _door.SetActive(false);
		_gradients.Clear();

	}

	public override void Interaction()
	{
		throw new System.NotImplementedException();
	}
}
public enum ColorDoor
{
	Red, Yellow, Blue
}
