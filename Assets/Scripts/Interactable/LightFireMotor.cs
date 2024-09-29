using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightFireMotor : MonoBehaviour
{
	public static LightFireMotor instance;
	[SerializeField] private float _distance;
	[SerializeField] private LayerMask _layerMask;
	[SerializeField] private AltarTorch _altarTorch;
	private void Awake()
	{
		instance = this;
	}
	public void Interactables(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			Ray ray = new Ray(transform.position,transform.forward);

			if(Physics.Raycast(ray, out RaycastHit hitInfo, _distance, _layerMask))
			{
				if(hitInfo.collider.TryGetComponent(out AltarTorch interactable))
				{
					_altarTorch = interactable;
				}
				else if (hitInfo.collider.TryGetComponent(out DoorTorch torch) && _altarTorch is not null)
				{
					torch.Interaction(_altarTorch.Getcolor(), _altarTorch.ColorDoor);
					_altarTorch = null;
				}
                else if (hitInfo.collider.TryGetComponent(out ColorTorch Colortorch) && _altarTorch is not null)
                {
                    bool isActive = Colortorch.Interaction(_altarTorch.Getcolor(), _altarTorch.ColorDoor);
					if(isActive)
						_altarTorch = null;
                }
            }
		}
	}
	public Gradient GetGradient()
	{
		return _altarTorch.Getcolor();
	}
}
