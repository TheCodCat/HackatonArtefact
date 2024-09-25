using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public bool isActive; // Галочка для отображения активности факела
    private Renderer torchRenderer;

    private void Start()
    {
        torchRenderer = GetComponent<Renderer>();
        UpdateTorchColor();
    }

    public void Toggle()
    {
        isActive = !isActive;
        UpdateTorchColor();
    }

    private void UpdateTorchColor()
    {
        torchRenderer.material.color = isActive ? Color.red : Color.black;
    }
}

