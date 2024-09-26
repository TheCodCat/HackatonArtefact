using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private QuestThree _questThree;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if(other.TryGetComponent(out CharacterController component))
        {
            _questThree.startTrigger();
        }
    }
}
