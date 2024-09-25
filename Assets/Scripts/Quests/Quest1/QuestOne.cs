using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestOne : MonoBehaviour
{
    [SerializeField] private int[] _password;
    [SerializeField] private List<TorchQuestOne> _torchPassList;
    public void GetTorch(TorchQuestOne torchQuestOne)
    {
        _torchPassList.Add(torchQuestOne);
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
        Debug.Log("Пароль верный");

    }
}
