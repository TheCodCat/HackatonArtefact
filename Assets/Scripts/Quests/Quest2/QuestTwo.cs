using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTwo : MonoBehaviour
{
    [SerializeField] private int _units, _tens, _hundreds;
    [SerializeField] private Text _unitsT,_tentT,_hundredsT;
	[SerializeField] private GameObject _kupol;
    [SerializeField] private int _current;
    [SerializeField] private int _necessary;

	public void GetNumbers(Discharge discharge)
    {
        switch (discharge)
        {
            case Discharge.Units:
                _units = (_units + 1) % 10;
                _unitsT.text = _units.ToString();
				break;
            case Discharge.Tens:
                _tens = (_tens + 10) % 100;
				_tentT.text = _tens.ToString();
				break;
            case Discharge.Hundreds:
                _hundreds = (_hundreds + 100) % 1000;
				_hundredsT.text = _hundreds.ToString();
				break;
        }

		_current = _units + _tens + _hundreds;
        if(_current == _necessary) _kupol.SetActive(false);
    }
}
