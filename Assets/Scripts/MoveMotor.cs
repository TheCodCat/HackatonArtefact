using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class MoveMotor : MonoBehaviour
{
	[SerializeField] private float _speed;
	[SerializeField] private CharacterController _controller;
	[Header("Гравитация")]
	[SerializeField] private bool _isGround;
	[SerializeField] private bool _isJump;
	[SerializeField] private float _gravity = -9.8f;
	[SerializeField] private float _speedJump;

	private Vector2 _inputDirection;
	private Vector3 _moveDirection;

	public void InputDirectionMove(InputAction.CallbackContext context)
	{
		_inputDirection = context.ReadValue<Vector2>();
		_moveDirection.x = _inputDirection.x;
		_moveDirection.z = _inputDirection.y;
	}
	public void Jump(InputAction.CallbackContext context)
	{
		if (context.performed)
			_isJump = true;
	}
	private void Update()
	{
		_isGround = _controller.isGrounded;
		if (!_isGround)
		{
			_moveDirection.y += _gravity * Time.deltaTime;
		}
		else
		{
			_moveDirection.y = -1f;
			if (_isJump)
			{
				_isJump = false;
				_moveDirection.y = _speedJump;
			}
		}
		_controller.Move(transform.TransformDirection(_moveDirection) * _speed * Time.deltaTime);
	}
}
