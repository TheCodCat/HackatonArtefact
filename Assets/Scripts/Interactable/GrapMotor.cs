using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrapMotor : MonoBehaviour
{
	[SerializeField] private float _distance;
	[SerializeField] private LayerMask _layerMask;
	[SerializeField] private StateMachin _stateMachin;
	[SerializeField] private Artefact _currentUp;

	private float _xRotate;
	private float _yRotate;

	public void Grap(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			Ray ray = new Ray(transform.position, transform.forward);

			if (Physics.Raycast(ray, out RaycastHit hitInfo, _distance, _layerMask))
			{
				if (hitInfo.collider.TryGetComponent(out Artefact grap) && _currentUp is null)
				{
					grap.Up();
					_currentUp = grap;
				}
				else if (hitInfo.collider.TryGetComponent(out AltarPoint point))
				{
					if(_currentUp is not null)
					{
						bool _iss = point.Interaction(_currentUp,_currentUp.ID);
						if(_iss) _currentUp = null;
					}
				}
			}
		}
	}
}
