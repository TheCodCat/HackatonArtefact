using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Altar : MonoBehaviour
{
    public static UnityAction OnActive;
    [SerializeField] private GameObject _obj;
    [SerializeField] private Torch[] _emtyTorchs;

    private void OnEnable()
    {
        OnActive += ActiveAltar;
    }
    private void OnDisable()
    {
        OnActive -= ActiveAltar;
    }
    private void ActiveAltar()
    {
        foreach (var item in _emtyTorchs)
        {
            if (!item.IsPlay) return;
        }
        _obj.SetActive(true);
    }
}
