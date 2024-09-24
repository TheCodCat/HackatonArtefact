using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rough : Interactable
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Interactable _interactable;
    private const string INTERACT = "Interact";
    public override void Interaction()
    {
        _animator.SetTrigger(INTERACT);
    }

    public void Activate()
    {
        _interactable.Interaction();
    }
}
