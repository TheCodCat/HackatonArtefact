using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTwo : MonoBehaviour
{
    [SerializeField] private int _units, _tens, _hundreds;
    public void GetNumbers(Discharge discharge)
    {
        switch (discharge)
        {
            case Discharge.Units:
                _units = (_units + 1) % 10;
                break;
            case Discharge.Tens:
                _tens = (_tens + 10) % 100;
                break;
            case Discharge.Hundreds:
                _hundreds = (_hundreds + 100) % 1000;
                break;
        }
        Debug.Log(_units + _tens + _hundreds);
    }
}
