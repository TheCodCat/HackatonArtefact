using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Altar : MonoBehaviour
{
	[SerializeField] private int _countArtefact;
	[SerializeField] private int _max;
	[Header("Названия сцен")]
	[SerializeField] private string _lose;
	[SerializeField] private string _win;
	public int CountArtafact => _countArtefact;
	public int Max => _max;
	public void AddArtefact()
	{
		_countArtefact++;
	}
	public string GetVariableEnd()
	{
		if (_countArtefact >= _max) return _win;
		else return _lose;
	}
}
