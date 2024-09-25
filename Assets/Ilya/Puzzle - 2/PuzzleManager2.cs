using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager2 : MonoBehaviour
{
    public Torch[] torches; 
    public GameObject door; 

    private void Update()
    {
        CheckTorches();
    }

    private void CheckTorches()
    {
        foreach (Torch torch in torches)
        {
            if (!torch.isActive)
            {
                return; // Если хотя бы один факел не активен, выходим
            }
        }
        door.SetActive(false);
    }
}

