using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest2Manager : MonoBehaviour
{
    public Torch[] torches; 
    public GameObject door1;
    public GameObject door2;

    private void Update()
    {
        CheckTorches();
    }

    private void CheckTorches()
    {
        foreach (Torch torch in torches)
        {
            if (!torch.IsPlay)
            {
                return; 
            }
        }
        door1.SetActive(false);
        door2.SetActive(false);
    }
}
