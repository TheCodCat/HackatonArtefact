using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefact : PickUp
{
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Collider _collider;
    public override void Up()
    {
        base.Up();
        _collider.enabled = false;
        _renderer.enabled = false;
    }
    public void ActiveAltar()
    {
        _collider.enabled = true;
        _renderer.enabled = true;
    }
}
