using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
	public void Interaction()
	{
		Debug.Log("Я открываюсь");
	}
}
