using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Cub : Grap
{
	[SerializeField] private Rigidbody _rb;
	public override void PickUp(Transform point)
	{
		_rb.isKinematic = true;
		_rb.transform.position = point.position;
		transform.rotation = point.rotation;
		transform.SetParent(point);
	}

	public override void Put()
	{
		_rb.isKinematic = false;
		transform.SetParent(null);
	}
}
