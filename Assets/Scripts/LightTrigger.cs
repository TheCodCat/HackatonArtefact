using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
	[SerializeField] private EmptyTorch[] _emptyTorches;
	private async void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent(out CharacterController component))
		{
			if (_emptyTorches.Length == 0) return;
            foreach (var item in _emptyTorches)
            {
				await Task.Delay((int)(Random.value * 1000));
				if(!item.IsPlay)
					item.Interaction();
            }
        }
	}
	private async void OnTriggerExit(Collider other)
	{
		if (other.TryGetComponent(out CharacterController component))
		{
			if (_emptyTorches.Length == 0) return;
			foreach (var item in _emptyTorches)
			{
				await Task.Delay((int)(Random.value * 1000));
				if (item.IsPlay)
					item.Interaction();
			}
		}
	}
}
