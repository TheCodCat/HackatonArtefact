using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrapMotor : MonoBehaviour
{
	[SerializeField] private float _distance;
	[SerializeField] private LayerMask _layerMask;
	[SerializeField] private StateMachin _stateMachin;
	[Header("Подбор предметов для осмотра")]
	[SerializeField] private Transform _point;
	[SerializeField] private Grap _currentGrap;

	private float _xRotate;
	private float _yRotate;

	public void Grap(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			Ray ray = new Ray(transform.position, transform.forward);

			if (Physics.Raycast(ray, out RaycastHit hitInfo, _distance, _layerMask))
			{
				if (hitInfo.collider.TryGetComponent(out Grap grap))
				{
					if (_currentGrap == null)
					{
						_stateMachin.ChangeState(StatePlayer.Grap);
						grap.PickUp(_point);
						_currentGrap = grap;
					}
					else
					{
						_stateMachin.ChangeState(StatePlayer.Game);
						grap.Put();
						_currentGrap = null;
					}
				}
			}
		}
	}

	public void GrapRotate(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			_xRotate += context.ReadValue<Vector2>().x;
			_yRotate += context.ReadValue<Vector2>().y;

			_currentGrap.transform.rotation = Quaternion.Euler(_yRotate,_xRotate,0);
		}
	}
}
