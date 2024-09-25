using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_2 : MonoBehaviour
{
    public Torch[] torches; 
    void OnMouseDown()
    {
        ToggleTorches();
    }

    private void ToggleTorches()
    {
        foreach (Torch torch in torches)
        {
            torch.Toggle();
        }
    }
}


