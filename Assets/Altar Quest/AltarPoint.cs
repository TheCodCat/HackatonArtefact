using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AltarPoint : Interactable
{
	[SerializeField] private Altar _altar;
    [SerializeField] private Transform _DownPoint;
	[SerializeField] private int _artefactID;
    private Artefact _artefact;

	public bool Interaction(Artefact myArt, int id)
	{
		Debug.Log($"{id} {_artefactID}");
		if (id != _artefactID) return false;

		_artefact = myArt;
		_artefact.transform.position = _DownPoint.position;
		_artefact.transform.SetParent(_DownPoint);
		_artefact.transform.forward = _DownPoint.forward;
		_artefact.ActiveAltar();
		_altar.AddArtefact();
		return true;
	}

	public override void Interaction()
	{

	}
}
