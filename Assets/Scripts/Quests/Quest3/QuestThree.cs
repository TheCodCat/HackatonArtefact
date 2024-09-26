using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestThree : MonoBehaviour
{
    [SerializeField] private Rigidbody _Sphere;

    public void startTrigger()
    {
        _Sphere.isKinematic = false;
    }
}
