using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest2Manager : Interactable
{
	[SerializeField] private List<RouchToTorch> _rouchToTorches;
	[SerializeField] private TorchQ2[] _torchs;
    [SerializeField] private Door[] _dors; 
	public override void Interaction()
	{
	}
	public void Interaction(int index)
	{
		_rouchToTorches[index].ActiveRouch();

        foreach (var item in _torchs)
        {
            if(!item.GetIsPlay()) return;
        }
        foreach (var item in _dors)
        {
            item.gameObject.SetActive(false);
        }
    }
}

[System.Serializable]
public class RouchToTorch
{
	public List<Torch> Torch;

	public void ActiveRouch()
	{
        foreach (var item in Torch)
        {
			item.Interaction();
        }

    }
}
