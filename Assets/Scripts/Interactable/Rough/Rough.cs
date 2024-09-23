using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rough : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator _animator;
    [SerializeField] private EmtyTorch _emtyTorch;
    private IInteractable _interactable;
    private const string INTERACT = "Interact";
    public void Interaction()
    {
        _animator.SetTrigger(INTERACT);
    }

    public void Activate()
    {
        _emtyTorch.Interaction();
    }
}
