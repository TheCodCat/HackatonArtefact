using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchQuestOne : Torch
{
    [SerializeField] private int _index;
    [SerializeField] private QuestOne _questOne;
    public int Index => _index;
	private void Start()
	{
		Interaction();
	}
	public override void Interaction()
    {
        if (!IsPlay)
        {
            base.Interaction();
            _questOne.GetTorch(this);
        }
    }
    public void TorchDisable()
    {
        _isPlay = false;
        _particleSystem.Stop();
        _light.gameObject.SetActive(false);
    }
}
