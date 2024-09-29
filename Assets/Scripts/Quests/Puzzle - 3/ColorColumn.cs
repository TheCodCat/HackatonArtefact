using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorColumn : MonoBehaviour
{
    [SerializeField] private UnityEvent OnActive;
    [SerializeField] private ColorTorch[] _colorTorches;
    public bool IsActive { get; private set; }
    public void GetColor()
    {
        foreach (var item in _colorTorches)
        {
            if (!item.IsPlay) return;
        }
        IsActive = true;
        OnActive?.Invoke();
    }
}

