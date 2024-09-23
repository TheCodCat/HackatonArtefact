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
	[SerializeField] private float _gravity = -9.8f;
	[SerializeField] private Vector3 _velocity;

	private Vector2 _inputDirection;
	private Vector3 _moveDirection;

	public void InputDirectionMove(InputAction.CallbackContext context)
	{
		_inputDirection = context.ReadValue<Vector2>();
		_moveDirection.x = _inputDirection.x;
		_moveDirection.z = _inputDirection.y;
	}
	private void FixedUpdate()
	{
		_isGround = _controller.isGrounded;
		_controller.Move(transform.TransformDirection(_moveDirection) * _speed * Time.deltaTime);
		if (!_isGround)
		{
			_velocity.y += _gravity * Time.deltaTime;
		}
		else _velocity.y = -1f;
		_controller.Move(_velocity * Time.deltaTime);
	}
}
