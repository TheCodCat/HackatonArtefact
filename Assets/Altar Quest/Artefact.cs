using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefact : PickUp
{
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Rigidbody _rb;
    public override void Up()
    {
        base.Up();
		_rb.isKinematic = true;
        _renderer.enabled = false;
    }
    public void ActiveAltar()
    {
        _renderer.enabled = true;
    }
}
