using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
	[SerializeField] private Rigidbody _rb;
	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent(out CharacterController component))
		{
			_rb.useGravity = true;
		}
	}
}
