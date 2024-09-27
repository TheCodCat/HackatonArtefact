using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestOne : MonoBehaviour
{
    [SerializeField] private int[] _password;
    [SerializeField] private List<TorchQuestOne> _torchPassList;
    [SerializeField] private Interactable[] _interactabls;
	public void GetTorch(TorchQuestOne torchQuestOne)
    {
        _torchPassList.Add(torchQuestOne);
        Debug.Log(_torchPassList.Count);
        if(_torchPassList.Count != _password.Length) return;

        for (int i = 0; i < _torchPassList.Count; i++)
        {
            if (_torchPassList[i].Index != _password[i])
            {
                foreach (var item in _torchPassList)
                {
                    item.TorchDisable();
                }
                _torchPassList.Clear();
                return;
            }
        }
        if (_interactabls.Length == 0) return;

        foreach (var item in _interactabls)
        {
            item.Interaction();
        }
	}
}
