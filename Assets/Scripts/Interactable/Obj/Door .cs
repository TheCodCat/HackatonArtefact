using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
	[SerializeField] private Animator _animator;
	[SerializeField] private AudioClip _clip;
	public override void Interaction()
	{
		Debug.Log("Я открылся");
		_animator.SetTrigger("Run");
		AudioSource.PlayClipAtPoint(_clip,transform.position,0.3f);
    }
}
