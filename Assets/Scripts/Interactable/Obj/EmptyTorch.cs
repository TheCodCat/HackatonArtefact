using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTorch : Torch
{
    public override void Interaction()
    {
        base.Interaction();
        Altar.OnActive?.Invoke();
    }
}
