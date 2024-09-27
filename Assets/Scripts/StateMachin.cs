using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StateMachin : MonoBehaviour
{
	public static StateMachin Instance;
	[SerializeField] private PlayerInput _playerInput;
	private void Awake()
	{
		Instance = this;
	}

	public void ChangeState(StatePlayer state)
	{
		_playerInput.SwitchCurrentActionMap(state.ToString());
	}
	public string GetGameMode()
	{
		return _playerInput.currentActionMap.name;
	}
}
