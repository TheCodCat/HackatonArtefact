using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoughQ2 : Rough
{
    [SerializeField] private Interactable[] _interactables;
    
    private void ToggleTorches()
    {
        foreach (Torch torch in _interactables)
        {
            torch.Interaction();
        }
    }
}
