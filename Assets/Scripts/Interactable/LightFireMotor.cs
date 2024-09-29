using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class LightFireMotor : MonoBehaviour
{
	public static LightFireMotor instance;
	[SerializeField] private float _distance;
	[SerializeField] private LayerMask _layerMask;
	[SerializeField] private AltarTorch _altarTorch;
    [SerializeField] private Image _fireImage;
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
					_fireImage.color = _altarTorch.GetColor();
				}
				else if (hitInfo.collider.TryGetComponent(out DoorTorch torch) && _altarTorch is not null)
				{
					torch.Interaction(_altarTorch.GetGradient(), _altarTorch.ColorDoor,_altarTorch.GetColor());
					_altarTorch = null;
                    _fireImage.color = Color.white;
                }
                else if (hitInfo.collider.TryGetComponent(out ColorTorch Colortorch) && _altarTorch is not null)
                {
                    bool isActive = Colortorch.Interaction(_altarTorch.GetGradient(), _altarTorch.ColorDoor);
					if (isActive)
					{
						_altarTorch = null;
                        _fireImage.color = Color.white;
                    }
                }
            }
		}
	}
	public Gradient GetGradient()
	{
		return _altarTorch.GetGradient();
	}
}
