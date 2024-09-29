using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Artefact : PickUp
{
    [SerializeField] private int _id;
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private AudioClip _audioClip;
    public int ID => _id;
    public override void Up()
    {
        base.Up();
		_rb.isKinematic = true;
        _renderer.enabled = false;
        AudioSource.PlayClipAtPoint(_audioClip,transform.position,0.1f);
    }
    public void ActiveAltar()
    {
        _renderer.enabled = true;
    }
}
