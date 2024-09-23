using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StateMachin : MonoBehaviour
{
	[SerializeField] private PlayerInput _playerInput;

	public void ChangeState(string state)
	{
		_playerInput.SwitchCurrentActionMap(state);
	}
}
