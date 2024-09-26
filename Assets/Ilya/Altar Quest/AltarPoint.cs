using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarPoint : MonoBehaviour, IInteractable
{
    [SerializeField] private Artefact _artefact;
    [SerializeField] private Transform _DownPoint;
    public void Interaction()
    {
        throw new System.NotImplementedException();
    }
    public void Interaction(Artefact myArt)
    {
        _artefact = myArt;
        _artefact.transform.position = _DownPoint.position;
        _artefact.ActiveAltar();
    }

}
