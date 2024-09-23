using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractableMotor : MonoBehaviour
{
	[SerializeField] private float _distance;
	[SerializeField] private LayerMask _layerMask;
	public void Interactables(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			Ray ray = new Ray(transform.position,transform.forward);

			if(Physics.Raycast(ray, out RaycastHit hitInfo, _distance, _layerMask))
			{
				if(hitInfo.collider.TryGetComponent(out IInteractable interactable))
				{
					interactable.Interaction();
				}
			}
		}
	}
}
