using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPuzzleManager3 : MonoBehaviour
{
    [SerializeField] private ColorColumn[] _colorColumns;
    [SerializeField] private GameObject _kupol;

    public void GetFire()
    {
        foreach (var item in _colorColumns)
        {
            if (!item.IsActive) return;

            _kupol.SetActive(false);
        }
    }
}

