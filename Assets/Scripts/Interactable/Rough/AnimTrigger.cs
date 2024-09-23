using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    [SerializeField] private Rough _rough;

    public void Activate()
    {
        _rough.Activate();
    }
}
