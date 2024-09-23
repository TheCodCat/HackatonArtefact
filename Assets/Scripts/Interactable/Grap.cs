using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Grap : MonoBehaviour
{
	public abstract void PickUp(Transform point);
	public abstract void Put();
}
