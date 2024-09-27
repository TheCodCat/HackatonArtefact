using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AltarPoint : Interactable
{
	[SerializeField] private Altar _altar;
    [SerializeField] private Artefact _artefact;
    [SerializeField] private Transform _DownPoint;

	public void Interaction(Artefact myArt)
	{
		_artefact = myArt;
		_artefact.transform.position = _DownPoint.position;
		_artefact.ActiveAltar();
		_altar.AddArtefact();
	}

	public override void Interaction()
	{

	}
}
